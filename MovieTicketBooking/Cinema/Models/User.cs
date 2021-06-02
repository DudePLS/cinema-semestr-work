using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Cinema.Models
{
    public class User : IdentityUser
    {
        public List<TicketBooking> TicketBookings { get; set; }
    }
}
