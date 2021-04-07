﻿using BlazorProducts.Client.Features;
using BlazorProducts.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class Pagination
    {
        [Parameter]
        public MetaData MetaData { get; set; }

        [Parameter]
        public int Spread { get; set; }

        [Parameter]
        public EventCallback<int> SelectedPage { get; set; }

        private List<PagingLink> links;

		protected override void OnParametersSet()
		{
			CreatePaginationLinks();
		}

		private void CreatePaginationLinks()
		{
			links = new List<PagingLink>();

			links.Add(new PagingLink(MetaData.CurrentPage - 1, MetaData.HasPrevious, "Previous"));

			for (int i = 1; i <= MetaData.TotalPages; i++)
			{
				if (i >= MetaData.CurrentPage - Spread && i <= MetaData.CurrentPage + Spread)
				{
					links.Add(new PagingLink(i, true, i.ToString())
					{ Active = MetaData.CurrentPage == i });
				}
			}

			links.Add(new PagingLink(MetaData.CurrentPage + 1, MetaData.HasNext, "Next"));
		}

		private async Task OnSelectedPage(PagingLink link)
		{
			if (link.Page == MetaData.CurrentPage || !link.Enabled)
				return;

			MetaData.CurrentPage = link.Page;

			await SelectedPage.InvokeAsync(link.Page);
		}
	}
}