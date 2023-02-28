using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Classes
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }  

    }
}
