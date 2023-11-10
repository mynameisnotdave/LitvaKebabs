using LitvaKebabs.Pages;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components
{
    public partial class OrderButton
    {
        [Parameter]
        public string MenuOrSauce { get; set; }

        public List<string> MenuItem = new List<string>();

        public List<decimal> MenuPrice = new List<decimal>();
        OrderMenuRoot orderMenuRoot = new OrderMenuRoot();
        private void AddMenuItemToReciept(KeyValuePair<string, decimal> item)
        {
     
            // Increase the quantity of the item clicked in our receipt
            
            // Update cart on view with the new value

        }
    }
}
