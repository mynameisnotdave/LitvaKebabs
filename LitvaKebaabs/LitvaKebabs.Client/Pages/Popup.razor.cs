/*
   https://stackoverflow.com/a/72005336
   CC-BY-SA 4.0
*/

using Microsoft.AspNetCore.Components;

namespace LitvaKebabs.Client.Pages
{
    public partial class Popup
    {
        [Parameter]
        public bool IsVisible { get; set; }

        [Parameter]
        public EventCallback<bool> IsVisibleChanged { get; set; }

        [Parameter]
        public string? HeaderText { get; set; }

        [Parameter]
        public string? BodyText { get; set; }

        public void Show(string bodyText, string headerText = "")
        {
            HeaderText = headerText;
            BodyText = bodyText;
            IsVisible = true;
           
        }

        private void Close()
        {
            HeaderText = string.Empty;
            BodyText = string.Empty;
            IsVisible = false;
            
        }
    }
}
