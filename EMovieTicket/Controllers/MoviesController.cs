using EMovieTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EMovieTicket.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppdbContext _appdbContext;

        public MoviesController(AppdbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }

        public async Task<IActionResult> Index()
        {
            var CinemaList = await _appdbContext.Movies.ToListAsync();
            return View();
        }
    }
}
