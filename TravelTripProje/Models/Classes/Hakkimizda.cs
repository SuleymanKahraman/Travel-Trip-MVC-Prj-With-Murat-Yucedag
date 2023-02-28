using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public string Explanation { get; set; }
    }
}
