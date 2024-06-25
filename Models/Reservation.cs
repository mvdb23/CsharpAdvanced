using System.ComponentModel.DataAnnotations;

namespace CsharpAdvanced23_24.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public Location Location { get; set; } // Two-way 1-to-many relationship with Location

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Customer Customer { get; set; } // Two-way 1-to-many relationship with Customer

        public float Discount { get; set; }
    }
}
