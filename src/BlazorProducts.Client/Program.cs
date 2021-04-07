using Blazored.Toast;
using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Shared.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace BlazorProducts.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddBlazoredToast();
            builder.Services.AddHttpClient("ProductsApi", (sp, client) => 
            {
                var apiConfiguration = sp.GetRequiredService<IOptions<ApiConfiguration>>().Value;
                client.BaseAddress = new Uri(apiConfiguration.BaseAddress + "/api/");
                client.EnableIntercept(sp);
            });

            builder.Services.AddScoped(
                sp => sp.GetService<IHttpClientFactory>().CreateClient("ProductsApi"));

            builder.Services.AddHttpClientInterceptor();

            builder.Services.AddScoped<IHttpProductsRepository, HttpProductsRepository>();
            builder.Services.AddScoped<HttpInterceptorService>();

            builder.Services.Configure<ApiConfiguration>
                (builder.Configuration.GetSection("ApiConfiguration"));

            await builder.Build().RunAsync();
        }
    }
}
