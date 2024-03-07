using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public string CustomerAddress { get; set; } = string.Empty;
        [MaxLength(58)]
        public string CustomerPostTown { get; set; } = string.Empty;
        [MaxLength(7)]
        public string CustomerPostcode { get; set; } = string.Empty;
        [MaxLength(11), Phone]
        public string CustomerPhone { get; set; } = string.Empty;
    }
}
