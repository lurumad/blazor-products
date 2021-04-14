using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Shared.Models;
using BlazorProducts.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class Products : IDisposable
    {
        public List<Product> ProductList { get; set; } = new List<Product>();
        public int TotalSize { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        protected override void OnInitialized()
        {
            Interceptor.RegisterEvent();
        }

        public async Task LoadProducts(ProductParameters productParameters)
        {
            var virtualizeResponse = await Repository.Products(productParameters);
            ProductList = virtualizeResponse.Items;
            TotalSize = virtualizeResponse.TotalSize;
        }

        private async Task DeleteProduct(Guid id)
        {
            await Repository.Delete(id);
        }

        public void Dispose() => Interceptor.DisposeEvent();
    }
}
