using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class AdresBlog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Adress { get; set;}
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}
