using BlazorProducts.Client.Features;
using BlazorProducts.Shared;
using BlazorProducts.Shared.Configuration;
using BlazorProducts.Shared.Models;
using BlazorProducts.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class HttpProductsRepository : IHttpProductsRepository
    {
        private readonly ApiConfiguration apiConfiguration = new ApiConfiguration();
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public HttpProductsRepository(
            HttpClient client,
            IOptions<ApiConfiguration> options)
        {
            this.client = client;
            apiConfiguration = options.Value;
        }

        public async Task Add(Product product) =>
            await client.PostAsJsonAsync("products", product);

        public async Task Delete(Guid id) =>
            await client.DeleteAsync(Path.Combine("products", id.ToString()));

        public async Task<Product> ProductBy(Guid id)
        {
            var product = await client.GetFromJsonAsync<Product>($"products/{id}");

            return product;
        }

        public async Task<VirtualizeResponse<Product>> Products(ProductParameters productParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageSize"] = productParameters.PageSize.ToString(),
                ["startIndex"] = productParameters.StartIndex.ToString()
            };

            var response = await client.GetAsync(QueryHelpers.AddQueryString("products", queryStringParam));

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<VirtualizeResponse<Product>>(content, options);
        }

        public async Task Update(Product product) =>
            await client.PutAsJsonAsync(Path.Combine("products", product.Id.ToString()), product);

        public async Task<string> UploadImage(MultipartFormDataContent content)
        {
            var post = await client.PostAsync("upload", content);
            var postContent = await post.Content.ReadAsStringAsync();
            var imageUrl = Path.Combine(apiConfiguration.BaseAddress, postContent);
            return imageUrl;
        }
    }
}
