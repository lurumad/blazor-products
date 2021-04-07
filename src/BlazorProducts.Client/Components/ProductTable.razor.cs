using BlazorProducts.Client.Shared;
using BlazorProducts.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class ProductTable
    {
        private Confirmation confirmation;
        private Guid productIdToDelete;

        [Parameter]
        public List<Product> Products { get; set; }

        [Parameter]
        public EventCallback<Guid> OnDelete { get; set; }

        private void CallConfirmationModal(Guid id)
        {
            productIdToDelete = id;
            confirmation.Show();
        }

        private async Task DeleteProduct()
        {
            confirmation.Hide();
            await OnDelete.InvokeAsync(productIdToDelete);
        }
    }
}
