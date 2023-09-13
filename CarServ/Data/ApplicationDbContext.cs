using CarServ.Models;
using Microsoft.EntityFrameworkCore;

namespace CarServNew.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Booking> bookings { get; set; }
    }
}
