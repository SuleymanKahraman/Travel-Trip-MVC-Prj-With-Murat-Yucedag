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
            //Blog Tablosundaki ilgili Id'ye ait tüm satırları liste halinde getirir. Böylece bizde link verdiğimizde "/Blog/BlogDetail/@item.Id" Db'den çekilmiş olan listeye gideriz. Aynı durum yorumlar içinde geçerlidir. 
            By.BlogValues = context.Blogs.Where(x => x.Id == Id).ToList();
            By.YorumValues = context.Yorumlars.Where(x => x.BlogId == Id).ToList();
            return View(By);
        }
    }
}
