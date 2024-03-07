namespace LitvaKebabs.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } // FK to customer
        
    }
}
