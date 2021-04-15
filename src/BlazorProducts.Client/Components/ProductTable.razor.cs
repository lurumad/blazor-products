using BlazorProducts.Client.Shared;
using BlazorProducts.Shared.Models;
using BlazorProducts.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class ProductTable
    {
        private Virtualize<Product> virtualize;
        private Confirmation confirmation;
        private Guid productIdToDelete;

        [Parameter]
        public List<Product> Products { get; set; }

        [Parameter]
        public int TotalSize { get; set; }

        [Parameter]
        public EventCallback<Guid> OnDelete { get; set; }

        [Parameter]
        public EventCallback<ProductParameters> OnScroll { get; set; }

        private async ValueTask<ItemsProviderResult<Product>> LoadProducts(ItemsProviderRequest request)
        {
            var pageSize = Math.Min(request.Count, TotalSize - request.StartIndex);

            await OnScroll.InvokeAsync(new ProductParameters
            {
                StartIndex = request.StartIndex,
                PageSize = pageSize == 0 ? request.Count : pageSize
            });

            return new ItemsProviderResult<Product>(Products, TotalSize);
        }

        private void CallConfirmationModal(Guid id)
        {
            productIdToDelete = id;
            confirmation.Show();
        }

        private async Task DeleteProduct()
        {
            confirmation.Hide();
            await OnDelete.InvokeAsync(productIdToDelete);
            await virtualize.RefreshDataAsync();
        }
    }
}
