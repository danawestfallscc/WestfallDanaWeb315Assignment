#pragma checksum "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b39175acca5c619bb6fa439a7202c95c3b8d35a"
// <auto-generated/>
#pragma warning disable 1591
namespace danaWestfallGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using danaWestfallGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\_Imports.razor"
using danaWestfallGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Grocery Store</h1>\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 5 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\Pages\GroceryStore.razor"
     foreach (var GroceryStore in GroceryStoreList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\Pages\GroceryStore.razor"
             GroceryStore.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\Pages\GroceryStore.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<input placeholder=\"Grocery Isle\">\r\n");
            __builder.AddMarkupContent(5, "<button>submit</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\danaw\OneDrive - St. Clair College\WestfallDanaWeb315Assignment\danaWestfallGroceryApp\Pages\GroceryStore.razor"
       
 private List<FoodItem> GroceryStoreList = new();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
