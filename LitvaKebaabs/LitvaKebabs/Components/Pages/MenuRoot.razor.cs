using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.JSInterop;

namespace LitvaKebabs.Components.Pages
{
    public partial class MenuRoot
    {
        [Inject]
        NavigationManager navigationManager { get; set; }

        [Inject]
        IJSRuntime jsRuntime { get; set; }

        //private readonly MenuService _menuService = new();
        //private readonly OrderService _orderService = new();

        public int KebabQty { get; set; } = 0;

        private int ReceiptCount = 0;
        private decimal cartTotal = 0;
        private List<Product> Cart = new();


        private void AddToReceipt(Product item)
        {
            cartTotal = 0;

            Cart.Add(item);
            ReceiptCount++;
        }

        private async Task SubmitOrder()
        {
            if (Cart.Count == 0)
            {
                await jsRuntime.InvokeVoidAsync("alert", "Cannot proceed, order has no items. Please add items to the cart and try again.");
            }
            else
            {
                Random random = new();
                // I can't wait for the first order to be order 935,312
                int ranId = random.Next(1, 1000000);
                /*Order order = new()
                {
                    // Please I hope this will not be empty
                    MenuItems = Cart,
                    Id = ranId,
                    OrderPrice = cartTotal
                };
                _orderService.UpsertOrder(order);*/

                /*navigationManager.NavigateTo(QueryHelpers.AddQueryString("/order-summary", "id", order.Id.ToString()));*/
            }

        }
    }
}
