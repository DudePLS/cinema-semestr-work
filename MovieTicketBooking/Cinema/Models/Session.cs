using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int CinemaId { get; set; }
        public Cinema1 Cinema { get; set; }
        
        public int Hall { get; set; }
        public List<Seat> AvailableSeats { get; set; } = new List<Seat>();
        public int TicketPrice { get; set; }

        public List<TicketBooking> TicketBookings { get; set; }
    }
}
