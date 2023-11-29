using LitvaKebabs.Services;
using LitvaKebabs.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using LitvaKebabs.Client.Pages;

namespace LitvaKebabs.Components.Pages
{
    public partial class OrderSummary
    {
        [Inject]
        IJSRuntime jsRuntime { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

        OrderService _orderService = new();
        Order order = new();

        [SupplyParameterFromQuery(Name = "id")]
        [Parameter]
        public string OrderId { get; set; }

        private Popup popupRef;

        private void OnSubmitClicked()
        {
            popupRef.Show("Thank you, your order is complete!");
            navigationManager.NavigateTo("/menu");
        }
    }
}
