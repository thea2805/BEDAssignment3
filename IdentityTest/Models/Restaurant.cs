using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        public List<Employee> ListOfEmployees { get; set; }

        public List<Booking> ListOfBookings { get; set; }
    }
}
