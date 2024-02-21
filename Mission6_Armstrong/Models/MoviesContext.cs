using Microsoft.EntityFrameworkCore;

namespace Mission6_Armstrong.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) //constructor
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
