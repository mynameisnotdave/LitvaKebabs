using LiteDB;
using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components.Pages
{
    public partial class StaffPortal
    {
        private decimal NewPrice { get; set; }
        public MenuItem MenuItem { get; set; }

        MenuService _menuService = new();

        AddMenuItemDialog dialog;

        private void AddMenuItem()
        {
            dialog.Show();
        }

        private EventCallback<string> NameChanged {  get; set; }
        private EventCallback<decimal> PriceChanged { get; set; }

        private void OnAmendedItem()
        {
            MenuItem = new();

            _menuService.UpdateMenuItem(MenuItem);
            StateHasChanged();
        }
    }
}
