using CleanMovie.Domain;

namespace CleanMovie.Application
{
    /// <summary>
    /// Essa classe representa os Uses Cases
    /// </summary>
    public interface IMovieService
    {
        IList<Movie> GetAllMovies();
    }
}
