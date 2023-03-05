using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{

    public class DefaultController : Controller
    {
        private readonly Context context;

        public DefaultController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }
        public PartialViewResult Partial1()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }
         public PartialViewResult Partial4()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }

    }
}
