// Attr: https://www.c-sharpcorner.com/article/blazor-web-assembly-3-2-addeditdelete-fully-functional-application-part-2/

using LitvaKebabs.Models;
using LitvaKebabs.Services;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace LitvaKebabs.Components.Pages
{
    public partial class AddMenuItemDialog
    {
        public Product Product { get; set; } = new Product();


        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Parameter, Required]
        public string AddOrModify { get; set; }


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
            Product = new Product { };
        }
        protected async Task HandleValidSubmit()
        {
            
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
