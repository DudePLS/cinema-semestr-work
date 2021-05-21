using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SixLabors.ImageSharp;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }
        public byte[] Image { get; set; }

        public List<Session> Sessions { get; set; }
    }
}
