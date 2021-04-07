using Blazored.Toast.Services;
using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class UpdateProduct : IDisposable
    {
        private Product product;
        private EditContext editContext;
        private bool formInvalid = true;

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = await Repository.ProductBy(Id);
            editContext = new EditContext(product);
            editContext.OnFieldChanged += EditContext_OnFieldChanged;
            Interceptor.RegisterEvent();
        }

        private void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !editContext.Validate();
            StateHasChanged();
        }

        public async Task Update()
        {
            await Repository.Update(product);

            ToastService.ShowSuccess("Product updated!");
        }

        public void Dispose()
        {
            Interceptor.DisposeEvent();
        }

        private void AssignImageUrl(string imageUrl) => product.ImageUrl = imageUrl;
    }
}
