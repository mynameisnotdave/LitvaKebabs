// Attr: https://www.c-sharpcorner.com/article/blazor-web-assembly-3-2-addeditdelete-fully-functional-application-part-2/

using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;

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
            MenuService.InsertMenuItem(MenuItem);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
