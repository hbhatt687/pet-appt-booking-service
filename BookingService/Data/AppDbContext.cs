using Microsoft.EntityFrameworkCore;
using BookingService.Models;

namespace BookingService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}