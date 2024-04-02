using LitvaKebabs.Services;
using LitvaKebabs.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LitvaKebabs.Components.Pages
{
    public partial class OrderSummary
    {
        [Inject]
        IJSRuntime jsRuntime { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

        /*OrderService _orderService = new();*/
        Order order = new();

        [SupplyParameterFromQuery(Name = "id")]
        [Parameter]
        public string OrderId { get; set; }

        private void OnSubmitClicked()
        {
            navigationManager.NavigateTo("/order-success");
        }
    }
}
