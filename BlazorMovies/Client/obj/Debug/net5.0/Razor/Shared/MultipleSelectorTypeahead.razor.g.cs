#pragma checksum "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a61ccfa06305b13f5e00d556058e45de1b70a57"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class MultipleSelectorTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorMovies.Client.Shared.MultipleSelectorTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
                                 (string searchText) => SearchMethod(searchText)

#line default
#line hidden
#nullable disable
            , 2, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
                                 (T item) => SelectedElement(item)

#line default
#line hidden
#nullable disable
            ), 3, (context) => (__builder2) => {
                __builder2.AddContent(4, 
#nullable restore
#line 7 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "list-group");
#nullable restore
#line 12 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
     foreach (var item in SelectedElements)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "draggable", "true");
            __builder.AddAttribute(10, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 15 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
                            () => HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
                           () => HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "list-group-item list-group-item-action");
            __builder.AddContent(13, 
#nullable restore
#line 19 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
                              () => SelectedElements.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "badge badge-primary badge-pill");
            __builder.AddAttribute(18, "style", "cursor: pointer");
            __builder.AddContent(19, "X");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MultipleSelectorTypeahead.razor"
       
    [Parameter] public List<T> SelectedElements { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }
    T draggedItem;

    private void SelectedElement(T item)
    {
        if (!SelectedElements.Any(x => x.Equals(item)))
        {
            SelectedElements.Add(item);
        }
    }

    private void HandleDragStart(T item)
    {
        draggedItem = item;
    }

    private void HandleDragOver(T item)
    {
        if (!item.Equals(draggedItem))
        {
            var dragElementIndex = SelectedElements.IndexOf(draggedItem);
            var elementIndex = SelectedElements.IndexOf(item);
            SelectedElements[elementIndex] = draggedItem;
            SelectedElements[dragElementIndex] = item;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Shared.MultipleSelectorTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ResultTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
