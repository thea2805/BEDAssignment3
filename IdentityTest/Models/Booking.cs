namespace Assignment3.Models
{
    public class Booking
    {
        public int BookingId {get; set;}

        public List<Room>? ListOfRooms { get; set;}

        public int EmployeeId { get; set;}
        public Employee Employee { get; set;}

        public int RestaurantId { get; set;}
        public Restaurant Restaurant { get; set;}
    }
}
