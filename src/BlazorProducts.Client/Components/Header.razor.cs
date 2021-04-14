using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Components
{
    public partial class Header
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }

        [CascadingParameter(Name = "TitleColor")]
        public string Color { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
