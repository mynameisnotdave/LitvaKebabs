using LitvaKebabs.Models;
using LitvaKebabs.Pages;
using LitvaKebabs.Util;
using Microsoft.AspNetCore.Components.Forms;

namespace LitvaKebabs.Components
{
    public partial class Receipt
    {
        PostcodeLookup postcodeLookup = new();
        private string navigateTo = "/order-review";
        public List<KebabMenu> GetMenuItem() {
            Dictionary<string, decimal> keyValuePairs = Menu.MenuItems;
            List<KebabMenu> kebabMenus = new List<KebabMenu>();
            foreach (var item in keyValuePairs)
            {
                kebabMenus.Add(new KebabMenu() { Item = item.Key, Price = item.Value });
            }
            return kebabMenus;
        }
        


        OrderButton orderButton = new OrderButton();
        
        private decimal TotalAmount()
        {
            return 0;
        }

    }
}
