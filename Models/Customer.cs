using System.ComponentModel.DataAnnotations;

namespace CsharpAdvanced23_24.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Reservation> Reservations { get; set; } // Two-way many-to-1 relationship with Reservation
    }
}
