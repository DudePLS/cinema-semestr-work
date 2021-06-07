using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NewPassword { get; set; }

        public List<TicketBooking> Tickets { get; set; } = new List<TicketBooking>();
    }
}
