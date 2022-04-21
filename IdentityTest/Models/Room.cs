using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }

        public List<Guest>? ListOfGuests { get; set; }

        public int BookingId { get; set; }
        public Booking? Booking { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
