using EMovieTicket.Data;
using EMovieTicket.Data.Services;
using EMovieTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
            _actorsService= actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var actorList = await _actorsService.GetAll();
            return View(actorList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
