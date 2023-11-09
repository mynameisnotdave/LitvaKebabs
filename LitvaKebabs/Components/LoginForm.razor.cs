using LitvaKebabs.Models;
using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Components
{
    public partial class LoginForm
    {
        [Parameter]
        public string LoginUser { get; set; }

        public Login? Model { get; set; }

        protected override void OnInitialized() => Model ??= new();

        private void Submit()
        {
            if(LoginUser != "customer" || LoginUser != "staff")
            {
                throw new Exception("ERROR: Login user has not been specified. Should either be 'customer' or 'staff'.");
            }
            else if (LoginUser == "customer")
            {
                navigationManager.NavigateTo("/customer-portal");
            }
            else if (LoginUser == "staff")
            {
                navigationManager.NavigateTo("/staff-portal");
            }
        }
    }
}
