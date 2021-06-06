using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DatabaseContext _context;

        public BookingModel bm = new BookingModel();

        public MoviesController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Movie(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult Session(int? id, BookingModel bm)
        {
            var session = _context.Sessions.Include(s => s.AvailableSeats).FirstOrDefault(s => s.Id == id);
            bm.session = session;
            
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bm.seats.Add(new SeatVM { row = i+1, seat = j+1 });
                }
            }
            return View(bm);
        }

        public async Task<IActionResult> Schedule(int? id)
        {
            var sessions = _context.Sessions.Where(s => s.MovieId == id);
            return View(await sessions.ToListAsync());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int sessionId, List<SeatVM> bookedseats)
        {
            Session session = _context.Sessions.FirstOrDefault(s => s.Id == sessionId);
            User user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            TicketBooking ticket = new TicketBooking { UserId = user.Id, User = user,Session = session, SessionId = sessionId, TotalCost = session.TicketPrice * bookedseats.Count };
            _context.Add(ticket);
            foreach(var seat in bookedseats)
            {
                _context.Add(new BookedSeat { Row = seat.row, seat = seat.seat, Ticket = ticket, TicketId = ticket.Id });
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Profile", "Home");
        }
    }
}
