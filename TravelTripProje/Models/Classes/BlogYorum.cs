namespace TravelTripProje.Models.Classes
{
    public class BlogYorum
    {
        // Enumerable System.Generic sınıfından aldığımız bir sınıf. Böylece biz bu sınıfta(BlogYorum) birden fazla Tablodan veri çekebileceğiz. Hem Blog tablosundaki verileri hem de Yorumlar tablosundaki verileri çekmek için kullanıyoruz. 
        public IEnumerable<Blog> BlogValues { get; set; }
        public IEnumerable<Yorumlar> YorumValues { get; set; }
        public IEnumerable<Blog> SonBlogs { get; set; }
    }
}
