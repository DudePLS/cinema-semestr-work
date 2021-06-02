using System.ComponentModel.DataAnnotations;

namespace Cinema.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required, MinLength(8, ErrorMessage = "Name must contain at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Введённые пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}