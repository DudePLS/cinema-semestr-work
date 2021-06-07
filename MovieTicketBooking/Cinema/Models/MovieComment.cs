using System;

namespace Cinema.Models
{
    public class MovieComment
    {
        public int Id { get; set; }
        
        public string Comment { get; set; }
       
        public DateTime PublishDate { get; set; }
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int StarRating { get; set; }
    }
}