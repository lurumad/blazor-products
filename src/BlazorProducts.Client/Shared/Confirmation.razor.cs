using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Shared
{
    public partial class Confirmation
    {
        private string modalDisplay;
        private bool showBackdrop;

        [Parameter]
        public EventCallback OnOKClicked { get; set; }

        [Parameter]
        public string BodyMessage { get; set; }

        public void Show()
        {
            modalDisplay = "block;";
            showBackdrop = true;
            StateHasChanged();
        }

        public void Hide()
        {
            modalDisplay = "none;";
            showBackdrop = false;
            StateHasChanged();
        }
    }
}
