// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Shared/MoviesList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }

    private async Task DeleteMovie(Movie movie)
    {
        await js.MyFunction("custom message");
        var confirmed = await js.Confirm($"Are you sure you want to delete {movie.Title}?");

        if (confirmed)
        {
            Movies.Remove(movie);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
