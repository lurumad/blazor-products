using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class Search
    {
        private Timer timer;

        public string SearchTerm { get; set; }

        [Parameter]
        public EventCallback<string> OnSearchChanged { get; set; }

        private void SearchChanged()
        {
            timer?.Dispose();

            timer = new Timer(OnTimerElapsed, null, 500, 0);
        }

        private void OnTimerElapsed(object state)
        {
            OnSearchChanged.InvokeAsync(SearchTerm);

            timer?.Dispose();
        }
    }
}
