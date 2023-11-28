using LitvaKebabs.Services;
using LitvaKebabs.Models;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components.Pages
{
    public partial class OrderSummary
    {
        OrderService _orderService = new();
        Order order = new();

        [SupplyParameterFromQuery(Name = "id")]
        [Parameter]
        public string OrderId { get; set; }

        protected override async Task OnInitializedAsync()
        {

        }
    }
}
