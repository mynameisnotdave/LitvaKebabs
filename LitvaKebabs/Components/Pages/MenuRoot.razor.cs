using Microsoft.AspNetCore.Components;
using LitvaKebabs.Services;
using LitvaKebabs.Models;

namespace LitvaKebabs.Components.Pages
{
    public partial class MenuRoot
    {
        private readonly MenuService _menuService = new();
        private readonly OrderService _orderService = new();

        public int KebabQty { get; set; } = 0;

        private int ReceiptCount = 0;
        private decimal cartTotal = 0;
        private List<MenuItem> Cart = [];


        private void AddToReceipt(MenuItem item)
        {
            cartTotal = 0;
            
            Cart.Add(item);
            ReceiptCount++;
        }
    }
}
