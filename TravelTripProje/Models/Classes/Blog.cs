using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set;}
    }
}
