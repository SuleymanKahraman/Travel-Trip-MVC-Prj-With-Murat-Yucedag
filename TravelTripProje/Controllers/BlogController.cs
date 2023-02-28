using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context context;
        BlogYorum By = new BlogYorum();
        public BlogController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            By.BlogValues = context.Blogs.ToList();
            By.SonBlogs=context.Blogs.Take(3).ToList();
            //var values = context.Blogs.ToList();
            return View(By);
        }
        public IActionResult BlogDetail(int Id)
        {
            //var blogbul = context.Blogs.Where(x => x.Id == Id).ToList();
            By.BlogValues = context.Blogs.Where(x => x.Id == Id).ToList();
            By.YorumValues = context.Yorumlars.Where(x => x.BlogId == Id).ToList();
            return View(By);
        }
    }
}
