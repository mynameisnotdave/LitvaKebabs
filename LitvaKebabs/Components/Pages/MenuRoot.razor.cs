using Microsoft.AspNetCore.Components;
using LitvaKebabs.Services;
using LitvaKebabs.Models;

namespace LitvaKebabs.Components.Pages
{
    public partial class MenuRoot
    {
        [Inject]
        NavigationManager navigationManager {  get; set; }
        private readonly MenuService _menuService = new();
        private readonly OrderService _orderService = new();

        public int KebabQty { get; set; } = 0;

        private int ReceiptCount = 0;
        private decimal cartTotal = 0;
        private List<MenuItem> Cart = new();


        private void AddToReceipt(MenuItem item)
        {
            cartTotal = 0;
            
            Cart.Add(item);
            ReceiptCount++;
        }

        private void SubmitOrder()
        {
            Random random = new();
            // I can't wait for the first order to be order 935,312
            int ranId = random.Next(1, 1000000);
            Order order = new()
            {
                // Please I hope this will not be empty
                MenuItems = Cart,
                Id = ranId
            };
            _orderService.UpdateOrder(order);
            navigationManager.NavigateTo("/order-summary");
        }
    }
}
