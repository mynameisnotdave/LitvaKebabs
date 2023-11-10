using Microsoft.AspNetCore.Components;
using LitvaKebabs.Util;

namespace LitvaKebabs.Pages
{
    public partial class OrderMenuRoot
    {

        public Dictionary<string, decimal> MenuItems = Menu.MenuItems;
  
        public Dictionary<string, decimal> SauceItems = Menu.SauceItems;

        public List<ReceiptItems> Receipt = new List<ReceiptItems>();

        // Receipt Type
        public class ReceiptItems
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; } = 0;
        }

        // Receipt State
        

    }
}
