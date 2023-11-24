using Microsoft.AspNetCore.Components;
using LitvaKebabs.Util;
using LitvaKebabs.Services;

namespace LitvaKebabs.Pages
{
    public partial class OrderMenuRoot
    {
        public string KebabItem { get; set; } = string.Empty;

        public decimal KebabPrice { get; set; }

        public int KebabQty { get; set; } = 0;
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
