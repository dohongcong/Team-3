using MvcMovies.Models;
using System.Collections.Generic;

namespace MvcMovies.Models
{
    public class Room
    {
        public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string People { get; set; }

		public string Bed { get; set; }

		public string Price { get; set; }
        

        public virtual List<Booking> Bookings { get; set; }
    }
}