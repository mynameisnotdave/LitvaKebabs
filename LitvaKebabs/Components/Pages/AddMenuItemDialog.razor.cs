// Attr: https://www.c-sharpcorner.com/article/blazor-web-assembly-3-2-addeditdelete-fully-functional-application-part-2/

using LiteDB;
using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Components.Pages
{
    public partial class AddMenuItemDialog
    {
        public MenuItem MenuItem { get; set; } = new MenuItem();

        [Inject]
        public IMenuService MenuService { get; set; }

        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Parameter, Required]
        public string AddOrModify { get; set; }

        public MenuItem EditingMenuItem { get; set; } = new()
        {
            Id = ObjectId.NewObjectId(),
            Name = "This is a test",
            Price = 9.99M
        };

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        private void ResetDialog()
        {
            MenuItem = new MenuItem { };
        }
        protected async Task HandleValidSubmit()
        {
            if (AddOrModify == "add")
            {
                MenuService.InsertMenuItem(MenuItem);
            } 
            else if (AddOrModify == "modify") 
            {
                MenuService.UpdateMenuItem(EditingMenuItem);            
            }
            
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
