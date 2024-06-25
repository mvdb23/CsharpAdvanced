using System.ComponentModel.DataAnnotations;

namespace CsharpAdvanced23_24.Models
{
    public class Landlord
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Image Avatar { get; set; } // Has a 1 to 1 relation with Image class

        public List<Location> Locations { get; set; } // Two-way many-to-1 relationship with Location
    }
}
