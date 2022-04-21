using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Type { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Room>? ListOfRooms { get; set; }

        public List<Booking>? Booking { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
