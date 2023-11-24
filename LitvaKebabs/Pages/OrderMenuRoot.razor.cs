using Microsoft.AspNetCore.Components;
using LitvaKebabs.Util;
using LitvaKebabs.Services;
using LitvaKebabs.Models;

namespace LitvaKebabs.Pages
{
    public partial class OrderMenuRoot
    {
        private readonly MenuService _menuService = new MenuService();

        public int KebabQty { get; set; } = 0;

        private int ReceiptCount = 0;
        private decimal cartTotal = 0;
        private List<Order> Cart = new();


        private void AddToReceipt(List<Order> item)
        {
            cartTotal = 0;
            Cart.Add(item);
            ReceiptCount++;
        }
    }
}
