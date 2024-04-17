using Microsoft.EntityFrameworkCore;
using WebApplication2.Models; // Import the namespace where User class is defined

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
