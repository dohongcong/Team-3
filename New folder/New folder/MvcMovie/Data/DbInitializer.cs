﻿using MvcMovie.Models;
using MvcMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MvcMoviesContext context)
        {
            // Delete the database, if it already exists. I do this because an
            // existing database may not be compatible with the entity model,
            // if the entity model was changed since the database was created.
            context.Database.EnsureDeleted();

            // Create the database, if it does not already exists. This operation
            // is necessary, if you use an SQL Server database.
            context.Database.EnsureCreated();

            // Look for any bookings.
            if (context.Booking.Any())
            {
                return;   // DB has been seeded
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer { Name="John Smith", Email="js@gmail.com", Phone="", Address="", Password="" },
                new Customer { Name="Jane Doe", Email="jd@gmail.com", Phone="", Address="", Password="" }
            };

            List<Room> rooms = new List<Room>
            {
                new Room { Title="A", Description="abcxyz", People="2", Bed="1",Price="1000" },
				new Room { Title="B", Description="abcxyz", People="2", Bed="1",Price="1000" },
				new Room { Title="C", Description="abcxyz", People="2", Bed="1",Price="1000" },
                new Room { Title="D", Description="abcxyz", People="2", Bed="1",Price="1000" },
            };

            DateTime date = DateTime.Today.AddDays(4);
            List<Booking> bookings = new List<Booking>
            {
                new Booking { StartDate=date, EndDate=date.AddDays(14), CustomerId=1 },
                new Booking { StartDate=date, EndDate=date.AddDays(14), CustomerId=2 },
                new Booking { StartDate=date, EndDate=date.AddDays(14), CustomerId=1 }
            };

            context.Customer.AddRange(customers);
            context.Room.AddRange(rooms);
			context.SaveChanges();
			context.Booking.AddRange(bookings);
            
        }
    }
}
