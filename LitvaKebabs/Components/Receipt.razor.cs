using LitvaKebabs.Models;
using LitvaKebabs.Components.Pages;
using LitvaKebabs.Util;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components
{
    public partial class Receipt
    {
        [Parameter]
        public string KebabItem {  get; set; } = string.Empty;

        [Parameter]
        public decimal KebabPrice {  get; set; }

        [Parameter]
        public int KebabQty { get; set; } = 0;

        private string navigateTo = "/order-review";
        
        public void RemoveMenuItems()
        {
            throw new NotImplementedException();
        }
        
        private decimal TotalAmount()
        {
            return 0;
        }

    }
}
