#pragma checksum "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3135837d51a77236d42e1245b5b90b764b8b4c49"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client
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
#nullable restore
#line 2 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnNavigateAsync", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Routing.NavigationContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Routing.NavigationContext>(this, 
#nullable restore
#line 5 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                                                                 OnNavigateAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "AdditionalAssemblies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(
#nullable restore
#line 6 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                              lazyLoadedAssemblies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(5);
                __builder2.AddAttribute(6, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 9 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 9 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(9);
                __builder2.AddAttribute(10, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorMovies.Client.Shared.CustomNotFound>(12);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/App.razor"
       
    private List<Assembly> lazyLoadedAssemblies = new List<Assembly>();

    private async Task OnNavigateAsync(NavigationContext args)
    {
        if (args.Path.EndsWith("counter"))
        {
            var assemblies = await lazyLoader.LoadAssembliesAsync(
                new List<string> { "MathNet.Numerics.dll" });
            lazyLoadedAssemblies.AddRange(assemblies);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LazyAssemblyLoader lazyLoader { get; set; }
    }
}
#pragma warning restore 1591
