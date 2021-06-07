using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [MinLength(7, ErrorMessage = "Name must contain at least 7 characters")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        
    }
}
