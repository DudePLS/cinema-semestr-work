using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string movieGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movies
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movies
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Profile()
        {
            User user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            var tickets = _context.TicketBookings.Include(t => t.BookedSeats).Include(t => t.Session).Where(t => t.UserId == user.Id).ToList();
            ChangePasswordViewModel vm = new ChangePasswordViewModel { Email = user.Email, Id = user.Id, Tickets = tickets };
            return View(vm);
        }
        public IActionResult Movie()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
    }
}
