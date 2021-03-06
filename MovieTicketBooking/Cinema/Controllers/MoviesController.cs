﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Web.Helpers;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DatabaseContext _context;

        public BookingModel bm = new BookingModel();

        public MovieCommentViewModel vm = new MovieCommentViewModel();
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

            Movie movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            vm.MovieId = id.Value;
            vm.Title = movie.Name;
            var comments = _context.MovieComments.Where(d => d.MovieId.Equals(id.Value)).ToList();
            vm.Comments = comments;
            vm.Movie = movie;
            var ratings = _context.MovieComments.Where(d => d.MovieId.Equals(id.Value)).ToList();
            if (ratings.Count() > 0)
            {
                var ratingSum = ratings.Sum(d => d.StarRating);
                ViewBag.RatingSum = ratingSum;
                var ratingCount = ratings.Count();
                ViewBag.RatingCount = ratingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }
            return View(vm);
        }
       

        public IActionResult Session(int? id, BookingModel bm)
        {
            var session = _context.Sessions.Include(s => s.AvailableSeats).FirstOrDefault(s => s.Id == id);
            bm.session = session;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (session.AvailableSeats.FirstOrDefault(s => s.Row == i + 1 && s.seat == j + 1) != null)
                    {
                        bm.seats.Add(new SeatVM { row = i + 1, seat = j + 1 });
                    }
                }
            }
            return View(bm);
        }

        public async Task<IActionResult> Schedule(int? id)
        {
            var sessions = _context.Sessions.Where(s => s.MovieId == id).Include(s => s.Movie).Include(s => s.Cinema);
            return View(await sessions.ToListAsync());
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int sessionId, BookingModel model)
        {
            Session session = _context.Sessions.FirstOrDefault(s => s.Id == sessionId);
            User user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            TicketBooking ticket = new TicketBooking { UserId = user.Id, User = user,Session = session, SessionId = sessionId };
            var movie = _context.Movies.FirstOrDefault(m => m.Id == ticket.Session.MovieId);
            foreach (var seat in model.seats)
            {
                if (seat.selected)
                {
                    _context.Add(new BookedSeat { Row = seat.row, seat = seat.seat, Ticket = ticket, TicketId = ticket.Id });
                    ticket.TotalCost += session.TicketPrice;
                    Seat remseat = _context.Seats.FirstOrDefault(s => s.Row == seat.row && s.seat == seat.seat && s.Session == session && s.SessionId == sessionId);
                    _context.Seats.Remove(remseat);
                }
            }

   
            await _context.SaveChangesAsync();
            var a = _context.TicketBookings.Include(s => s.BookedSeats).FirstOrDefault(t => t.UserId == user.Id && sessionId == session.Id);

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("srimprajder@gmail.com", "qwerass1");

            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Cinema",
            "admin@example.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(user.UserName,
            user.Email);
            message.To.Add(to);

            string subject = "Билеты в кино на фильм " + movie.Name;

            message.Subject = subject;
            BodyBuilder bodyBuilder = new BodyBuilder();
            StringBuilder sb = new StringBuilder();
            foreach (var seat in ticket.BookedSeats)
            {
                sb.Append($"Ряд: {seat.Row}, Место: {seat.seat} \n");
            }
           sb.Append($"Кинотеатр № {ticket.Session.CinemaId}\nДата:{ticket.Session.Date.ToString("d")}\nВремя:{ticket.Session.Time} \n");
            bodyBuilder.TextBody = sb.ToString();
            message.Body = bodyBuilder.ToMessageBody();

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
            ViewBag.msg = "Билеты отправлены на email";
            return RedirectToAction("Profile", "Home");
        }
    }
}
