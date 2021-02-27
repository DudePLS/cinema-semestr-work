using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class Cart
    {
        public  int Id { get; set; }
        public string seatNo { get; set; }
        public string UserId { get; set; }
        public DateTime datE { get; set; }
        public int Amount { get; set; }
        public int MovieId { get; set; }


    }
}
