using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class ProductDetails
    {
        public Product Product { get; set; } = new Product();

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Product = await Repository.ProductBy(Id);
        }
    }
}
