using CleanMovie.Domain;

namespace CleanMovie.Application
{
    /// <summary>
    /// Implementação dos casos de uso relacionados a filmes.
    /// </summary>
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        /// <summary>
        /// Construtor da classe MovieService, que realiza a injeção de dependência do repositório de filmes.
        /// </summary>
        /// <param name="movieRepository">Instância do repositório de filmes.</param>
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        /// <summary>
        /// Retorna uma lista com todos os filmes disponíveis, utilizando o repositório.
        /// </summary>
        /// <returns>Lista de objetos do tipo Movie.</returns>
        public IList<Movie> GetAllMovies()
        {
            IList<Movie> movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
