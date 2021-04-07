using Blazored.Toast.Services;
using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class CreateProduct : IDisposable
    {
        private Product product = new Product();
        private EditContext editContext;
        private bool formInvalid = true;

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        protected override void OnInitialized()
        {
            editContext = new EditContext(product);
            editContext.OnFieldChanged += EditContext_OnFieldChanged;
            Interceptor.RegisterEvent();
        }

        private void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !editContext.Validate();
            StateHasChanged();
        }

        public async Task Create()
        {
            await Repository.Add(product);

            ToastService.ShowSuccess("Product added!");
            product = new Product();
            editContext.OnValidationStateChanged += EditContext_OnValidationStateChanged;
            editContext.NotifyValidationStateChanged();
        }

        private void EditContext_OnValidationStateChanged(object sender, ValidationStateChangedEventArgs e)
        {
            formInvalid = true;
            editContext.OnFieldChanged -= EditContext_OnFieldChanged;
            editContext = new EditContext(product);
            editContext.OnFieldChanged += EditContext_OnFieldChanged;
            editContext.OnValidationStateChanged -= EditContext_OnValidationStateChanged;
        }

        public void Dispose()
        {
            Interceptor.DisposeEvent();
            editContext.OnFieldChanged -= EditContext_OnFieldChanged;
            editContext.OnValidationStateChanged -= EditContext_OnValidationStateChanged;
        }

        private void AssignImageUrl(string imageUrl) => product.ImageUrl = imageUrl;
    }
}
