using LitvaKebabs.Models;
using LitvaKebabs.Pages;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components
{
    public partial class OrderButton
    {
        [Parameter]
        public string MenuItem { get; set; } = string.Empty;

        [Parameter]
        public string MenuPrice {  get; set; } = string.Empty;

        [Parameter]
        public List<KebabMenu> MenuValue { get; set; } = new List<KebabMenu>();

        [Parameter]
        public EventCallback<List<KebabMenu>> MenuItemChanged { get; set; }
        
        private Task OnMenuItemClicked()
        {


        }
    }
}
