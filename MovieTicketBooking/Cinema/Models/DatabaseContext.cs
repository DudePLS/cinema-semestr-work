using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Models
{
    public class DatabaseContext : IdentityDbContext
    {
        new public DbSet<User> Users { get; set; }
        public DbSet<Cinema1> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<TicketBooking> TicketBookings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<BookedSeat> BookedSeats { get; set; }

        public DbSet<MovieComment> MovieComments { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}
