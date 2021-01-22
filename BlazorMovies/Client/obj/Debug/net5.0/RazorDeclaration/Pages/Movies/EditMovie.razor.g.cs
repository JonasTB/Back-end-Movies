// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Pages.Movies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/home/alunom13/Área de Trabalho/ASPNET CORE/BlazorMovies/ASP.NET Core 5/Module 6 - HTTP and Entity Framework Core/Start/BlazorMovies/BlazorMovies/Client/Pages/Movies/EditMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    private Movie Movie;

    private List<Genre> NotSelectedGenres = new List<Genre>()
    {
        new Genre(){Id = 2, Name = "Comedy"},
        new Genre(){Id = 3, Name = "Drama"}
    };

    private List<Genre> SelectedGenres = new List<Genre>()
    {
        new Genre(){Id = 1, Name = "Action"}
    };

    protected override void OnInitialized()
    {
        Movie = new Movie() { Id = MovieId, Title = "My Movie" };
    }

    private void Edit()
    {
        Console.WriteLine("editing the movie...");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
