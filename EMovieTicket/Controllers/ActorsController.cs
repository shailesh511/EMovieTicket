using EMovieTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EMovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        public readonly AppdbContext _appdbContext;
        public ActorsController(AppdbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }
        public IActionResult Index()
        {
            var avtorList = _appdbContext.Actors.ToList();
            return View();
        }
    }
}
