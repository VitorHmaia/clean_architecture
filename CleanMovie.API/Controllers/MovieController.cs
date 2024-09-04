using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService) 
        {
            _movieService = movieService;
        }

        [HttpGet(Name = "GetAllMovies")]
        public ActionResult Get() 
        {
            var moviesFromService = _movieService.GetAllMovies();
            return Ok(moviesFromService);
        }
    }
}
