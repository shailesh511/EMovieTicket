using EMovieTicket.Data;
using EMovieTicket.Data.Services;
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
    }
}
