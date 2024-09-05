using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    /// <summary>
    /// Implementação do repositório de filmes, que utiliza uma lista estática para simular a persistência dos dados.
    /// </summary>
    public class MovieRepository : IMovieRepository
    {
        /// <summary>
        /// Lista estática que armazena os filmes cadastrados.
        /// Simulando entrada de dados no banco. Método Add do EF por exemplo.
        /// </summary>
        public static IList<Movie> movies = new List<Movie>()
        {
            new Movie { Id = 1, Title = "Homem de Ferro", Description = "Homem que usa armadura do Iron Golem", ProductionCompany = "Marvel Studios" },
            new Movie { Id = 2, Title = "Homem de Ferro 2", Description = "Homem que usa armadura do Gold Golem", ProductionCompany = "Marvel Studios" },
        };

        /// <summary>
        /// Retorna a lista de todos os filmes disponíveis no repositório.
        /// </summary>
        /// <returns>Lista de objetos do tipo Movie.</returns>
        public IList<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
