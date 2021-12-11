// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontendPaulo.Pages.Publication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using FrontendPaulo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using FrontendPaulo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Crear.razor"
using FrontendPaulo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Crear.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Crear.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publication/crear")]
    public partial class Crear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Crear.razor"
       

    Publication oPublication = new Publication();

    Response<object> oResponse = new Response<object>();

    String Url = "/api/Publication";

    Alert oAlert = new Alert();

    private async Task Save()
    {

        if (validateMaxDate())
        {
            oPublication.CreateDate = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ",";
            oPublication.CreateDate += DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            var response = await Http.PostAsJsonAsync<Publication>(Url, oPublication);
            oResponse = response.Content.ReadFromJsonAsync<Response<object>>().Result;

            if (oResponse.Success == 0) oAlert.isBad(oResponse.Message);

            else
            {
                oAlert.isGood("Publication" + " ' " + oPublication.Title + " ' " + " Created");
                oPublication.Reset();
            }
        }
    }

    private Boolean validateMaxDate()
    {
        if (DateTime.Now.Year.ToString().Equals(oPublication.AuxDate.Year.ToString()))
        {
            if (DateTime.Now.Month.ToString().Equals(oPublication.AuxDate.Month.ToString()))
            {
                if (Convert.ToInt32((oPublication.AuxDate.Day)) > Convert.ToInt32(DateTime.Now.Day.ToString()))
                    return oAlert.isBad("Publication Date is greater than the current date");
            }
        }

        oPublication.PublicationDate = DateTime.Now.ToString().Split(" ")[0];

        return validateTitle();
    }

    private Boolean validateTitle()
    {
        if (oPublication.Title.Equals("")) return oAlert.isBad("Field Title is required");

        oPublication.Title = oPublication.Title.Trim();

        return validateLink();
    }

    private Boolean validateLink()
    {
        if (oPublication.Link.Equals("")) return oAlert.isBad("Field Link is required");

        oPublication.Link = oPublication.Link.Trim();

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591