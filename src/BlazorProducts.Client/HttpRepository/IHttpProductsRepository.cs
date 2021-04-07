using BlazorProducts.Client.Features;
using BlazorProducts.Shared.Models;
using BlazorProducts.Shared.RequestFeatures;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public interface IHttpProductsRepository
    {
        Task<PagingResponse<Product>> Products(ProductParameters productParameters);
        Task<Product> ProductBy(Guid id);
        Task Add(Product product);
        Task<string> UploadImage(MultipartFormDataContent content);
        Task Update(Product product);
        Task Delete(Guid id);
    }
}
