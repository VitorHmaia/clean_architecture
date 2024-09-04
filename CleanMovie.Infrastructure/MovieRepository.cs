using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static IList<Movie> movies = new List<Movie>()
        {
        new Movie {Id = 1, Title = "Homem de Ferro",Description = "Homem que usa armadura do Iron Golen",ProductionCompany = "Marvel Studios"},
        new Movie { Id = 2, Title = "Homem de Ferro 2", Description = "Homem com usa armadura do Gold Golem", ProductionCompany = "Marvel Studios" },
        }; 
        

        public IList<Movie> GetAllMovies() 
        {
            return movies;
        }
    }
}
