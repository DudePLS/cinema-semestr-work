using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Cinema1
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public List<Session> Sessions { get; set; }
    }
}
