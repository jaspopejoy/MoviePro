using Microsoft.AspNetCore.Mvc;
using MoviePro.Services.Interfaces;

namespace MoviePro.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IRemoteMovieService _tmdbMovieService;
        private readonly IDataMAppingService _mappingService;

        public ActorsController(IRemoteMovieService tmdbMovieService, IDataMAppingService mappingService)
        {
            _tmdbMovieService = tmdbMovieService;
            _mappingService = mappingService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var actor = await _tmdbMovieService.ActorDetailAsync(id);
            actor = _mappingService.MapActorDetail(actor);
            return View(actor);
        }
    }
}
