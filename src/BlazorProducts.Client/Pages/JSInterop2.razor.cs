using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class JSInterop2
    {
        private MouseCoordinates coordinates = new MouseCoordinates();

        [Inject]
        public IJSRuntime JavaScript { get; set; }

        [JSInvokable]
        public static string CalculateSquareRoot(int number)
        {
            return $"The square root of {number} is {Math.Sqrt(number)}";
        }

        [JSInvokable("CalculateSquareRootOnlyResult")]
        public static string CalculateSquareRoot(int number, bool onlyResult)
        {
            return onlyResult ? Math.Sqrt(number).ToString() : $"The square root of {number} is {Math.Sqrt(number)}";
        }

        private async Task SendDotNetInstanceToJS()
        {
            var dotNetObjRef = DotNetObjectReference.Create(this);

            await JavaScript.InvokeVoidAsync("jsFunctions.registerMouseCoordinatesHandler", dotNetObjRef);
        }

        [JSInvokable]
        public void ShowCoordinates(MouseCoordinates coordinates)
        {
            this.coordinates = coordinates;

            StateHasChanged();
        }

    }

    public class MouseCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
