using BlazorProducts.Client.HttpRepository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Shared
{
    public partial class ImageUpload
    {
        private string fileUploadMessage = "No file choosen";

        [Parameter]
        public string ImgUrl { get; set; }

        [Parameter]
        public EventCallback<string> OnChange { get; set; }

        [Inject]
        public IHttpProductsRepository Repository { get; set; }

        private async Task HandleSelected(InputFileChangeEventArgs e)
        {
            var imageFile = e.File;

            if (imageFile is null)
            {
                return;
            }

            fileUploadMessage = imageFile.Name;

            var resizedFile = await imageFile.RequestImageFileAsync("image/png", 300, 500);

            using var ms = resizedFile.OpenReadStream(resizedFile.Size);
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition =
                new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
            content.Add(new StreamContent(ms, Convert.ToInt32(resizedFile.Size)), "image", imageFile.Name);

            ImgUrl = await Repository.UploadImage(content);

            await OnChange.InvokeAsync(ImgUrl);
        }
    }
}
