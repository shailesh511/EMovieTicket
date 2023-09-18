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
            var moviesList = await _appdbContext.Movies.Include(n=>n.Cinema).ToListAsync();
            return View(moviesList);
        }
    }
}
