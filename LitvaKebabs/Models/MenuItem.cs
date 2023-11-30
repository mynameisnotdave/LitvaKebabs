using LiteDB;

namespace LitvaKebabs.Models
{
    public class MenuItem
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
