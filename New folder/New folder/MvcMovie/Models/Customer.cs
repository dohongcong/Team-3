using MvcMovies.Models;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }

        public string Password { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
