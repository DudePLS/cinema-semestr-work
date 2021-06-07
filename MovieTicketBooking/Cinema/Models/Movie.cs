using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(400,ErrorMessage = "Description must contain maximum 400 characters")]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required,RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Invalid rating format")]
        public int Rating { get; set; }

        public string AgeRating { get; set; }

        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public byte[] Image { get; set; }

        public List<Session> Sessions { get; set; }

        public List<MovieComment> MovieComments { get; set; }
    }
}
