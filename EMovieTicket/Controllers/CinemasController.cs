using EMovieTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Controllers
{
    public class CinemasController : Controller
    {
        public readonly AppdbContext _appdbContext;

        public CinemasController(AppdbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }
        public async Task<IActionResult> Index()
        {
            var CinemaList = await _appdbContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
