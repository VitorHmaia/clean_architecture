using CleanMovie.Application;
using CleanMovie.Infrastructure;

// Cria o builder da aplicação web com as configurações padrões
var builder = WebApplication.CreateBuilder(args);

// Configura os controladores (API Controllers) para o projeto
builder.Services.AddControllers();

// Configuração do Swagger para documentar a API.
// Swagger é uma ferramenta que gera documentação interativa para APIs
// A URL https://aka.ms/aspnetcore/swashbuckle contém mais informações sobre como configurar o Swagger no ASP.NET Core.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração da injeção de dependência
// Aqui, estamos registrando a interface IMovieService com sua implementação MovieService.
// Sempre que IMovieService for solicitado, uma instância de MovieService será fornecida.
builder.Services.AddScoped<IMovieService, MovieService>();

// Da mesma forma, registramos o IMovieRepository com a implementação MovieRepository
// Uma nova instância de MovieRepository será fornecida sempre que IMovieRepository for solicitado.
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

// Constrói a aplicação com base nas configurações definidas acima
var app = builder.Build();

// Configura a pipeline de requisição HTTP para o ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Ativa o Swagger e sua interface gráfica (Swagger UI) para acessar a documentação da API
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Habilita o redirecionamento de HTTPS para garantir que as requisições sejam seguras
app.UseHttpsRedirection();

// Configura a autorização para verificar se o usuário tem permissão para acessar certos recursos
app.UseAuthorization();

// Mapeia os controladores, conectando as rotas definidas nas classes de controller com os endpoints da API
app.MapControllers();

// Inicia a aplicação e começa a escutar as requisições HTTP
app.Run();
