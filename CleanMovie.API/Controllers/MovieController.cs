using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    /// <summary>
    /// Controlador da API respons�vel pelas opera��es relacionadas a filmes.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        /// <summary>
        /// Construtor do MoviesController, com inje��o de depend�ncia do servi�o de filmes.
        /// </summary>
        /// <param name="movieService">Inst�ncia do servi�o de filmes.</param>
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        /// <summary>
        /// Endpoint que retorna todos os filmes dispon�veis.
        /// </summary>
        /// <returns>Resposta HTTP com a lista de filmes.</returns>
        [HttpGet(Name = "GetAllMovies")]
        public ActionResult Get()
        {
            var moviesFromService = _movieService.GetAllMovies();
            return Ok(moviesFromService);
        }
    }
}
