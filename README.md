# CleanMovie API

## Descrição

Este projeto implementa a **Clean Architecture** em .NET 7, utilizando o padrão **Repository** e **ORM**. Ele é composto por várias camadas organizadas em pastas, representando diferentes responsabilidades, como API, Application, Domain e Infrastructure. O projeto é um exemplo de uma API para gerenciar filmes.

## Requisitos Funcionais

### Linguagem e Versão
- **C#**
- **.NET 7**

### Sistema Operacional
- Funciona em qualquer sistema operacional que suporte o .NET 7 (Windows, Linux, macOS).

### Tecnologias Utilizadas
- **ASP.NET Core** para a criação da API.
- **Injeção de Dependência** para gerenciar serviços.
- **Clean Architecture** para separar responsabilidades e facilitar manutenções e testes.
- **Repository Pattern** para abstração do acesso a dados.

<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg" alt=".NET Logo" width="150"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/>
</p>

## Instalação de Dependências

1. Certifique-se de ter o .NET 7 instalado. Você pode baixar o SDK aqui: [Instalar .NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).

2. Clone o repositório em sua máquina:

    ```bash
    git clone https://github.com/VitorHmaia/clean_architecture.git
    cd clean_architecture
    ```

3. Restaure as dependências do projeto:

    ```bash
    dotnet restore
    ```

## Como Executar o Projeto

1. Navegue até o diretório do projeto `CleanMovie.API`:

    ```bash
    cd CleanMovie.API
    ```

2. Execute o projeto:

    ```bash
    dotnet run
    ```

3. A API estará disponível em `http://localhost:5000` por padrão.

4. Para acessar os endpoints disponíveis, use o seguinte exemplo de requisição:

    - **GET**: `http://localhost:5000/api/movies`

    Esse endpoint retorna uma lista de todos os filmes armazenados no repositório.

## Estrutura do Código

O projeto segue a **Clean Architecture** e está dividido nas seguintes camadas:

- **CleanMovie.API**: Contém os controladores da API, como o `MoviesController`, responsável por expor os endpoints.
- **CleanMovie.Application**: Define interfaces e casos de uso, como `IMovieService` e `IMovieRepository`.
- **CleanMovie.Domain**: Representa as entidades do sistema, como o modelo `Movie`.
- **CleanMovie.Infrastructure**: Contém a implementação de repositórios para acesso a dados, como o `MovieRepository`.

### Exemplo de Código

#### MovieController.cs
```csharp
[HttpGet(Name = "GetAllMovies")]
public ActionResult Get() 
{
    var moviesFromService = _movieService.GetAllMovies();
    return Ok(moviesFromService);
}
```
Este código define um endpoint GET que retorna a lista de filmes obtida pelo serviço IMovieService.

`MovieRepository.cs`
```csharp
public IList<Movie> GetAllMovies() 
{
    return movies;
}
```

O repositório simula uma lista de filmes para demonstrar o padrão Repository e a separação de camadas.

## Exemplos de Execução
Requisição GET para listar filmes:

URL: http://localhost:5000/api/movies

Resposta:
```csharp
[
    {
        "id": 1,
        "title": "Homem de Ferro",
        "description": "Homem que usa armadura do Iron Golen",
        "productionCompany": "Marvel Studios"
    },
    {
        "id": 2,
        "title": "Homem de Ferro 2",
        "description": "Homem com usa armadura do Gold Golem",
        "productionCompany": "Marvel Studios"
    }
]
```

## Explicação Detalhada do Projeto
*Controller*: A camada de API é exposta através do MoviesController, responsável por processar requisições HTTP e retornar respostas adequadas.

*Serviço*: O MovieService implementa os casos de uso definidos, servindo como intermediário entre a API e o repositório.

*Repositório*: O MovieRepository é responsável por fornecer os dados da aplicação. Ele implementa a interface IMovieRepository, garantindo a separação entre regras de negócio e acesso a dados.

## Dicas de Uso
Modifique a lista de filmes no MovieRepository para testar diferentes respostas.
Utilize ferramentas como o Postman ou o Insomnia para fazer chamadas à API e verificar os retornos.
