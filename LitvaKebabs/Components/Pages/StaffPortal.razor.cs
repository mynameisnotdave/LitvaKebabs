using LiteDB;
using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components.Pages
{
    public partial class StaffPortal
    {
        public MenuItem MenuItem { get; set; }

        MenuService _menuService = new();

        private string NewName;
        private decimal NewPrice;

        AddMenuItemDialog addDialog;
        AddMenuItemDialog modifyDialog;

        private void AddMenuItem()
        {
            addDialog.Show();
        }

        private EventCallback<string> NameChanged {  get; set; }
        private EventCallback<decimal> PriceChanged { get; set; }

        private void OnAmendedItem(MenuItem menuItem)
        {
            addDialog.EditingMenuItem = menuItem;
            modifyDialog.Show();
        }
    }
}
