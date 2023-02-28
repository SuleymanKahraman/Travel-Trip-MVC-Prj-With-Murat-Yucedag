using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        private readonly Context context;
        public AboutController(Context _context)
        {
            context= _context;
        }
        public IActionResult Index()
        {
            var values = context.Hakkimizdas.ToList();
            return View(values);
        }
    }
}
