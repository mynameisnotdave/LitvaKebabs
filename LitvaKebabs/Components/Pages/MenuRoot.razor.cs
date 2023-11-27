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
        private List<MenuItem> Cart = new List<MenuItem>();


        private void AddToReceipt(MenuItem item)
        {
            cartTotal = 0;
            
            Cart.Add(item);
            ReceiptCount++;
        }

        private void SubmitOrder()
        {
            // TODO: Not sure what to place here for the database stuff.
            //_orderService.UpdateOrder()
            navigationManager.NavigateTo("/order-summary");
        }
    }
}
