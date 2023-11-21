﻿using LitvaKebabs.Models;
using LitvaKebabs.Pages;
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

        }
        
        private decimal TotalAmount()
        {
            return 0;
        }

    }
}
