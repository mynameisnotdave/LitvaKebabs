using LitvaKebabs.Models;
using LitvaKebabs.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace LitvaKebabs.Components
{
    public partial class OrderButton
    {
        [Parameter]
        public string MenuItem { get; set; } = string.Empty;

        [Parameter]
        public decimal MenuPrice {  get; set; }

        public List<decimal> MenuPrice = new List<decimal>();
        OrderMenuRoot orderMenuRoot = new OrderMenuRoot();
        private void AddMenuItemToReciept(KeyValuePair<string, decimal> item)
        {
            
            

        private Task OnMenuItemClicked()
        {
            return MenuItemClicked.InvokeAsync(MenuItem);
        }
        
    }
}
