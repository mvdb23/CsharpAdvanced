using System.ComponentModel.DataAnnotations;

namespace CsharpAdvanced23_24.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Description { get; set; }

        public LocationType Type { get; set; }

        public int Rooms { get; set; }

        public int NumberOfGuests { get; set; }

        public Features LocationFeatures { get; set; } // Changed name to LocationFeatures to avoid error CS0102

        public List<Image> Images { get; set; } // One-way many-to-1 relationship with Image

        public float PricePerDay { get; set; }

        public List<Reservation> Reservations { get; set; } // Two-way many-to-1 relationship with Reservation

        public Landlord Landlord { get; set; } // Two-way 1-to-many relationship with Landlord

        [Flags]
        public enum Features
        {
            Smoking = 1,
            PetsAllowed = 2,
            Wifi = 4,
            TV = 8,
            Bath = 16,
            Breakfast = 32
        }

        public enum LocationType
        {
            Appartment,
            Cottage,
            Chalet,
            Room,
            Hotel,
            House
        }

    }
}
