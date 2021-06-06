using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.ViewModels;

namespace Cinema.ViewModels
{
    public class BookingModel
    {
        public List<SeatVM> seats { get; set; }
        public Session session { get; set; }
        public BookingModel()
        {
            seats = new List<SeatVM>();
        }
    }
}
