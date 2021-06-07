using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.ViewModels;

namespace Cinema.Controllers
{
    public class MovieCommentController : Controller
    {
        private readonly DatabaseContext _context;

        public MovieCommentController(DatabaseContext context)
        {
            _context = context;
        }
        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}
        
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Add(MovieCommentViewModel vm)
        {
            var comment = vm.SingleComment;
            var movieId = vm.MovieId;
            var rating = vm.Rating;

            MovieComment movieComment = new MovieComment()
            {
                MovieId = movieId,
                Comment = comment,
                StarRating = rating,
                PublishDate = DateTime.Now
            };
            _context.MovieComments.Add(movieComment);
            _context.SaveChanges();

            return RedirectToAction("Movie","Movies", new { id = movieId });
        }
    }
}
