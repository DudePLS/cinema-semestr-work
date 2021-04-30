using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }

        public List<Session> Sessions { get; set; }
    }
}
