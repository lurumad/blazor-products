using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace BlazorProducts.Client.HttpInterceptor
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor interceptor;
        private readonly NavigationManager navigationManager;
        private readonly IToastService toastService;

        public HttpInterceptorService(
            HttpClientInterceptor interceptor,
            NavigationManager navigationManager,
            IToastService toastService)
        {
            this.interceptor = interceptor;
            this.navigationManager = navigationManager;
            this.toastService = toastService;
        }

        public void RegisterEvent() => interceptor.AfterSend += Interceptor_AfterSend;
        public void DisposeEvent() => interceptor.AfterSend -= Interceptor_AfterSend;

        private void Interceptor_AfterSend(object sender, HttpClientInterceptorEventArgs e)
        {
            if (e.Response is null)
            {
                navigationManager.NavigateTo("/error");
                throw new HttpResponseException("Server not available");
            }

            var message = "";

            if (!e.Response.IsSuccessStatusCode)
            {
                switch (e.Response.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        navigationManager.NavigateTo("/404");
                        message = "Resource not found";
                        break;
                    case System.Net.HttpStatusCode.NotFound:
                        navigationManager.NavigateTo("/unauthorized");
                        message = "Unauthorized access";
                        break;
                    case System.Net.HttpStatusCode.BadRequest:
                        message = "Invalid request. Please try again";
                        toastService.ShowError(message);
                        break;
                    default:
                        navigationManager.NavigateTo("/error");
                        message = "Something was wrong. Please contact the administrator";
                        break;
                }

                throw new HttpResponseException(message);
            }
        }
    }
}
