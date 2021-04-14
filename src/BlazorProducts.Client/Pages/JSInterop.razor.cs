using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class JSInterop
    {
        private IJSObjectReference module;
        private string email;
        private string message;
        private ElementReference element;
        private Person person = new Person();
        private string errorMessage;

        [Inject]
        public IJSRuntime JavaScript { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                module = await JavaScript.InvokeAsync<IJSObjectReference>("import", "./scripts/jsInterop.js");

                await FocusAndStyleElement();

                await ThrowError();
            }
        }

        private async Task ShowAlert()
        {
            await module.InvokeVoidAsync("showAlert", "Hello from C#");
        }

        private async Task ShowAlertObject()
        {
            await module.InvokeVoidAsync("showAlertObject", new { Name = "luru", Email = "lruiz@plainconcepts.com" });
        }

        private async Task ShowPrompt()
        {
            email = await module.InvokeAsync<string>("showPrompt", "What's your email?");
        }

        private async Task ShowComplexObject()
        {
            var person = await module.InvokeAsync<Person>("complexObject");
            message = $"Name: {person.Name} Email: {person.Email}";
        }

        private async Task FocusAndStyleElement()
        {
            await module.InvokeVoidAsync("focusAndStyleElement", element);
        }

        private async Task FocusAndStyleComponent()
        {
            await module.InvokeVoidAsync("focusAndStyleComponent", "inputComponent");
        }

        public async Task ThrowError()
        {
            try
            {
                await module.InvokeVoidAsync("throwError");

            }
            catch (JSException exception)
            {
                errorMessage = exception.Message;
                StateHasChanged();
            }
        }

        private class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
