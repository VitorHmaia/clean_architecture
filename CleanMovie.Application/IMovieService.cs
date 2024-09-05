using CleanMovie.Domain;

namespace CleanMovie.Application
{
    /// <summary>
    /// Interface responsável por definir os casos de uso relacionados a filmes.
    /// </summary>
    public interface IMovieService
    {
        /// <summary>
        /// Retorna uma lista com todos os filmes disponíveis.
        /// </summary>
        /// <returns>Lista de objetos do tipo Movie.</returns>
        IList<Movie> GetAllMovies();
    }
}
