namespace LitvaKebabs.Models
{
    public class Order
    {
        public List<MenuItem> MenuItems { get; set; }
        public decimal OrderPrice { get; set; }
        public int Id { get; set; }
    }
}
