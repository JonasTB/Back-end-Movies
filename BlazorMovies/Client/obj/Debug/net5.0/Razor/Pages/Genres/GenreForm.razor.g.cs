#pragma checksum "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769f2b8a768e5b592d5a48c596af62b6a503be51"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Genres
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
    public partial class GenreForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor"
                 Genre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label>Name:</label>\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor"
                                                          Genre.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Genre.Name = __value, Genre.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Genre.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n            ");
                __Blazor.BlazorMovies.Client.Pages.Genres.GenreForm.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor"
                                      () => Genre.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n\n    ");
                __builder2.AddMarkupContent(19, "<button class=\"btn btn-success\" type=\"submit\">Save Changes</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Genres/GenreForm.razor"
       
    [Parameter] public Genre Genre { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Genres.GenreForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
