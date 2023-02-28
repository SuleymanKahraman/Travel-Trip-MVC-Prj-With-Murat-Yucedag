using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
    }
}
