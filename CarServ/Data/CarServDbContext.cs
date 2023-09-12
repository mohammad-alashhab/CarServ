using Microsoft.EntityFrameworkCore;
using CarServ.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CarServ.Data
{
    public class CarServDbContext : IdentityDbContext
    {
        public CarServDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
