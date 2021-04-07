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
        public MetaData MetaData { get; set; } = new MetaData();
        private ProductParameters productParameters = new ProductParameters();

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Interceptor.RegisterEvent();
            await LoadProducts();
        }

        public async Task SelectedPage(int page)
        {
            productParameters.PageNumber = page;
            await LoadProducts();
        }

        public async Task LoadProducts()
        {
            var pagingResponse = await Repository.Products(productParameters);
            ProductList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        public async Task SetPageSize(int pageSize)
        {
            productParameters.PageSize = pageSize;
            productParameters.PageNumber = 1;

            await LoadProducts();
        }

        private async Task SearchChanged(string searchTerm)
        {
            productParameters.PageNumber = 1;
            productParameters.SearchTerm = searchTerm;

            await LoadProducts();
        }

        private async Task SortChanged(string orderBy)
        {
            productParameters.OrderBy = orderBy;

            await LoadProducts();
        }

        private async Task DeleteProduct(Guid id)
        {
            await Repository.Delete(id);

            if (productParameters.PageNumber > 1 && ProductList.Count == 1)
            {
                productParameters.PageNumber--;
            }

            await LoadProducts();
        }

        public void Dispose() => Interceptor.DisposeEvent();
    }
}
