using Cinema.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Dashboard()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovie([Bind("Id,Name,Description,Genre,Rating,ReleaseDate")] Movie movie, MvViewModel mvm)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;
                if(mvm.Image != null)
                {
                    using (var binaryReader = new BinaryReader(mvm.Image.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)mvm.Image.Length);
                    }
                    movie.Image = imageData;
                }
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Dashboard));
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMovie(int? id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Dashboard));
        }

        public async Task<IActionResult> EditMovie(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMovie(int id, [Bind("Id,Name,Description,Genre,Rating,ReleaseDate")] Movie movie, MvViewModel mvm)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    byte[] imageData = null;
                    if (mvm.Image != null)
                    {
                        using (var binaryReader = new BinaryReader(mvm.Image.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)mvm.Image.Length);
                        }
                        movie.Image = imageData;
                    }
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Dashboard));
            }
            return View(movie);
        }

        public IActionResult AddSession()
        {
            ViewBag.Cinemas = new SelectList(_context.Cinemas.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSession(int id, [Bind("CinemaId,MovieId,Date,Time,Hall,TicketPrice")] Session session)
        {
            if (ModelState.IsValid)
            {
                for(int i = 0; i < 9; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        _context.Add(new Seat { Row = i+1, seat = j+1, Session=session, SessionId = session.Id });
                    }
                }
                session.MovieId = id;
                _context.Add(session);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Dashboard));
            }

            return View();
        }

        public IActionResult AddCinema()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCinema([Bind("Location")] Cinema1 cinema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cinema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Dashboard));
            }
            return View();
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
