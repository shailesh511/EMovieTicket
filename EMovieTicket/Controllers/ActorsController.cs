using EMovieTicket.Data;
using EMovieTicket.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EMovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
            _actorsService= actorsService;
        }
        public IActionResult Index()
        {
            var actorList = _actorsService.GetAll();
            return View(actorList);
        }
    }
}
