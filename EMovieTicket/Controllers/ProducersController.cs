using EMovieTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EMovieTicket.Controllers
{
    public class ProducersController : Controller
    {
        public readonly AppdbContext _appdbContext;

        public ProducersController(AppdbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }
        public IActionResult Index()
        {
            var ProducerList = _appdbContext.Producers.ToList();
            return View();
        }
    }
}
