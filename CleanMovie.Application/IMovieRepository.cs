using CleanMovie.Domain;

namespace CleanMovie.Application
{
    /// <summary>
    /// Interface que define os métodos para manipulação de filmes no repositório.
    /// </summary>
    public interface IMovieRepository
    {
        /// <summary>
        /// Retorna uma lista com todos os filmes disponíveis.
        /// </summary>
        /// <returns>Lista de objetos do tipo Movie.</returns>
        IList<Movie> GetAllMovies();
    }
}
