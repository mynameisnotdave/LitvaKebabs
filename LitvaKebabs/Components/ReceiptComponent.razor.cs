﻿using LitvaKebabs.Models;
using LitvaKebabs.Pages;
using LitvaKebabs.Util;
using Microsoft.AspNetCore.Components.Forms;

namespace LitvaKebabs.Components
{
    public partial class ReceiptComponent
    {
        private List<KebabMenu> GetMenuItem() {
            Dictionary<string, decimal> keyValuePairs = Menu.MenuItems;
            List<KebabMenu> kebabMenus = new List<KebabMenu>()
            {
                new KebabMenu(){Item=$"{keyValuePairs.Keys.FirstOrDefault()}",Price=keyValuePairs.Values.FirstOrDefault()}
            };
            return kebabMenus;
        }
        

        OrderButton orderButton = new OrderButton();
        
        private decimal TotalAmount()
        {
            return 0;
        }

    }
}
