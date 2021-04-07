using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class PageSizeDropDown
    {
        [Parameter]
        public EventCallback<int> SelectedPageSize { get; set; }

        private async Task OnPageSizeChanged(ChangeEventArgs eventArgs)
        {
            await SelectedPageSize.InvokeAsync(int.Parse(eventArgs.Value.ToString()));
        }
    }
}
