using Microsoft.AspNetCore.Components;
using LitvaKebabs.Util;
using LitvaKebabs.Services;
using LitvaKebabs.Models;

namespace LitvaKebabs.Pages
{
    public partial class MenuRoot
    {
        private readonly MenuService _menuService = new MenuService();
        private readonly OrderService _orderService = new OrderService();

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
