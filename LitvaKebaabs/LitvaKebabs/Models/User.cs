using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [EmailAddress(ErrorMessage = "Your username is your email address.")]
        public string UserUsername { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string UserPassword { get; set; }

        public virtual Customer? Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
