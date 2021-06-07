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
        [Required]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
      
        [Required]
        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        public int MovieId { get; set; }
        [Required]
        public Movie Movie { get; set; }

        public int CinemaId { get; set; }
        [Required]
        public Cinema1 Cinema { get; set; }
       
        [Required, RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Invalid hall format")]
        public int Hall { get; set; }
        public List<Seat> AvailableSeats { get; set; } = new List<Seat>();
        [Required, RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Invalid price format")]
        public int TicketPrice { get; set; }

        public List<TicketBooking> TicketBookings { get; set; }
    }
}
