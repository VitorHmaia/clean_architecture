using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        IList<Movie> GetAllMovies();
    }
}
