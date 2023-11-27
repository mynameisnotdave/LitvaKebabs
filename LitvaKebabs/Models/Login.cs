using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress(ErrorMessage = "Your username is your email address.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
