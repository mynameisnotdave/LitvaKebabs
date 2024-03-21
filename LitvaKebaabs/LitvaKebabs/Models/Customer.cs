using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(200)]
        public string CustomerFirstName { get; set; } = string.Empty;
        [MaxLength(200)]
        public string CustomerLastName { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        [MaxLength(58)]
        public string CustomerPostTown { get; set; } = string.Empty;
        [MaxLength(7)]
        public string CustomerPostcode { get; set; } = string.Empty;
        [MaxLength(11), Phone]
        public string CustomerPhone { get; set; } = string.Empty;
    
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress(ErrorMessage = "Your username is your email address.")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string CustomerPassword { get; set; }

        public int RoleId {get; set;}
        public virtual Role? Role {get; set;}
        
    }
}
