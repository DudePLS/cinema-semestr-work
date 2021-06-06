﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public int Row { get; set; }
        public int seat { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
