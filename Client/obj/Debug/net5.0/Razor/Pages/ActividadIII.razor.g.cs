#pragma checksum "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19c3f998ad6756cc13caffd8d230ab7de77d3bdc"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas_G34.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using ProyPeliculas_G34.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using ProyPeliculas_G34.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\ProyPeliculas_G34\Client\_Imports.razor"
using ProyPeliculas_G34.Shared.Entity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class ActividadIII : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
#nullable restore
#line 3 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
     foreach (var fish in GetFishes())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-group mb-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-3");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 8 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
                               fish.FishImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "img-thumbnail");
            __builder.AddAttribute(11, "alt");
            __builder.AddAttribute(12, "width", "200px");
            __builder.AddAttribute(13, "height", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-9");
            __builder.OpenElement(17, "h5");
            __builder.AddAttribute(18, "class", "text-center");
            __builder.AddMarkupContent(19, "\r\n                        Especie de pez: ");
            __builder.OpenElement(20, "small");
            __builder.AddAttribute(21, "class", "text-muted");
            __builder.AddContent(22, 
#nullable restore
#line 12 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
                                                                   fish.FishSpecie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "blockquote");
            __builder.AddAttribute(25, "class", "blockquote text-center");
            __builder.AddMarkupContent(26, "\r\n                        Descripción:\r\n                        ");
            __builder.OpenElement(27, "small");
            __builder.AddAttribute(28, "class", "text-muted");
            __builder.AddContent(29, 
#nullable restore
#line 16 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
                                                   fish.FishDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        <br>\r\n                        Tipo de agua en la que habita:\r\n                        ");
            __builder.OpenElement(31, "small");
            __builder.AddAttribute(32, "class", "text-muted");
            __builder.AddContent(33, 
#nullable restore
#line 19 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
                                                   fish.TypeOfWater

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "footer");
            __builder.AddAttribute(36, "class", "blockquote-footer");
            __builder.OpenElement(37, "cite");
            __builder.AddContent(38, 
#nullable restore
#line 21 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
                                   fish.PublicationDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\ProysCicloIII\ProyPeliculas_G34\Client\Pages\ActividadIII.razor"
       
    private List<Fish> GetFishes()
    {
        return new List<Fish>(){
new Fish()
{
FishSpecie = "Beta 1", FishDescription = "Descripción del tipo de pez Beta 1",TypeOfWater = "Dulce",FishImage
= "/Images/Beta/bet.jpg", PublicationDate = new DateTime(2021, 09, 20)},
new Fish()
{
FishSpecie = "Beta 2", FishDescription = "Descripción del tipo de pez Beta 2",TypeOfWater = "Salada",FishImage
= "/Images/Beta/beta2.jpg", PublicationDate = new DateTime(2021, 08, 20)},
new Fish()
{
FishSpecie = "Beta 3", FishDescription = "Descripción del tipo de pez Beta 3",TypeOfWater = "Dulce",FishImage
= "/Images/Beta/beta3.jpg", PublicationDate = new DateTime(2021, 07, 20)},
new Fish()
{
FishSpecie = "Beta 4", FishDescription = "Descripción del tipo de pez Beta 4",TypeOfWater = "Salada",FishImage
= "/Images/Beta/beta4.jpeg", PublicationDate = new DateTime(2021, 09, 20)},
new Fish()
{
FishSpecie = "Beta 5", FishDescription = "Descripción del tipo de pez Beta 5",TypeOfWater = "Dulce",FishImage
= "/Images/Beta/beta5.jpeg", PublicationDate = new DateTime(2021, 08, 20)},
new Fish()
{
FishSpecie = "Beta 6", FishDescription = "Descripción del tipo de pez Beta 6",TypeOfWater = "Salada",FishImage
= "/Images/Beta/beta8.jpg", PublicationDate = new DateTime(2021, 07, 20)}
};
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
