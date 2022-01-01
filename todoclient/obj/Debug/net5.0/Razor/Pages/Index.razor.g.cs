#pragma checksum "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d90437d5acdfe614de46bca34d088a0c5b1f66"
// <auto-generated/>
#pragma warning disable 1591
namespace todoclient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using todoclient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/lfuller/Projects/todoappapi/todoclient/_Imports.razor"
using todoclient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
using todoclient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
using todoclient.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
 if (todos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 9 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
}
else
{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
         foreach (var todo in todos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
#nullable restore
#line 14 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
__builder.AddContent(2, todo.title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
         
 
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<todoclient.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/lfuller/Projects/todoappapi/todoclient/Pages/Index.razor"
      
    List<Todo> todos;

    async Task LoadTodos()
    {
        todos = await responseManager.GetAllEpisodes();
        await InvokeAsync(StateHasChanged);
    }

    protected override async Task OnParametersSetAsync()
    {
        await LoadTodos();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ResponseManager responseManager { get; set; }
    }
}
#pragma warning restore 1591
