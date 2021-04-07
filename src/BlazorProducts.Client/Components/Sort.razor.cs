﻿using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class Sort
    {
        [Parameter]
        public EventCallback<string> OnSortChanged { get; set; }

        private async Task ApplySort(ChangeEventArgs eventArgs)
        {
            if (eventArgs.Value.ToString() != "-1")
            {
                await OnSortChanged.InvokeAsync(eventArgs.Value.ToString());
            }
        }
    }
}
