using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class AnaSayfa
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
    }
}
