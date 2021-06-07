using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class MovieCommentViewModel
    {
        public string Title { get; set; }

        public List<MovieComment> Comments { get; set; }
        public string SingleComment { get; set;}

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public int Rating { get; set; }
    }
}
