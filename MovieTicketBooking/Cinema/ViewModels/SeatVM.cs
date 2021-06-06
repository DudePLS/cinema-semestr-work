using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.ViewModels
{
    public class SeatVM
    {
        public int row { get; set; }
        public int seat { get; set; }
        public bool selected { get; set; }
    }
}
