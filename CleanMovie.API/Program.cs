using CleanMovie.Application;
using CleanMovie.Infrastructure;

// Cria o builder da aplica��o web com as configura��es padr�es
var builder = WebApplication.CreateBuilder(args);

// Configura os controladores (API Controllers) para o projeto
builder.Services.AddControllers();

// Configura��o do Swagger para documentar a API.
// Swagger � uma ferramenta que gera documenta��o interativa para APIs
// A URL https://aka.ms/aspnetcore/swashbuckle cont�m mais informa��es sobre como configurar o Swagger no ASP.NET Core.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura��o da inje��o de depend�ncia
// Aqui, estamos registrando a interface IMovieService com sua implementa��o MovieService.
// Sempre que IMovieService for solicitado, uma inst�ncia de MovieService ser� fornecida.
builder.Services.AddScoped<IMovieService, MovieService>();

// Da mesma forma, registramos o IMovieRepository com a implementa��o MovieRepository
// Uma nova inst�ncia de MovieRepository ser� fornecida sempre que IMovieRepository for solicitado.
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

// Constr�i a aplica��o com base nas configura��es definidas acima
var app = builder.Build();

// Configura a pipeline de requisi��o HTTP para o ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Ativa o Swagger e sua interface gr�fica (Swagger UI) para acessar a documenta��o da API
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Habilita o redirecionamento de HTTPS para garantir que as requisi��es sejam seguras
app.UseHttpsRedirection();

// Configura a autoriza��o para verificar se o usu�rio tem permiss�o para acessar certos recursos
app.UseAuthorization();

// Mapeia os controladores, conectando as rotas definidas nas classes de controller com os endpoints da API
app.MapControllers();

// Inicia a aplica��o e come�a a escutar as requisi��es HTTP
app.Run();
