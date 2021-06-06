using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class TicketBooking
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public List<BookedSeat> BookedSeats { get; set; } = new List<BookedSeat>();
        public int TotalCost { get; set; }
    }
}