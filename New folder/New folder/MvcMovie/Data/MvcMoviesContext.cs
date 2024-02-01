using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovies.Models;

namespace MvcMovie.Data
{
    public class MvcMoviesContext : DbContext
    {
        public MvcMoviesContext(DbContextOptions<MvcMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Customer> Customer { get; set; }
    }
}
