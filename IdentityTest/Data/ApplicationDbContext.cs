using Assignment3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Guest>? Guests { get; set; }
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Restaurant>? Restaurants { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        



    }
}