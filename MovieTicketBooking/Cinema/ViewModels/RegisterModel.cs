using System.ComponentModel.DataAnnotations;

namespace Cinema.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Введённые пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}