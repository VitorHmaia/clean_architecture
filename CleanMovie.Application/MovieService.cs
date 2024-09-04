using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        //Construtor para fazer injeção de dependencia
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IList<Movie> GetAllMovies()
        {
            IList<Movie> movies = _movieRepository.GetAllMovies();

            return movies;
        }
    }
}
