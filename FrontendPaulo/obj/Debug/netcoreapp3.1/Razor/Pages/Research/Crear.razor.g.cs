#pragma checksum "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fbba862140a56d4f5b3d1810499946361b03da6"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontendPaulo.Pages.Research
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
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
using FrontendPaulo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/research/crear")]
    public partial class Crear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                 oResearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container-fluid");
                __builder2.AddMarkupContent(6, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-6");
                __builder2.AddMarkupContent(12, "\r\n\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-6");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "file");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                         rutaInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rutaInput = __value, rutaInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(25, "<div class=\"col-sm-6\">\r\n                        <a href=\"/research/listar\" class=\"btn btn-primary btn-lg btn-block\"> View </a>\r\n                    </div>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(31, "\r\n\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-6");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Title");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                                  oResearch.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oResearch.Title = __value, oResearch.Title))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oResearch.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n");
#nullable restore
#line 40 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
             if (!@rutaInput.Equals(""))
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(43, "                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-6");
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.OpenElement(47, "img");
                __builder2.AddAttribute(48, "src", "/Images/Research/" + (
#nullable restore
#line 43 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                rutaInput.Substring(12)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "img-fluid");
                __builder2.AddAttribute(50, "alt", "Responsive image");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 45 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-sm-12");
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(61);
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "placeholder", "Abstract");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                                  oResearch.Abstract

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oResearch.Abstract = __value, oResearch.Abstract))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oResearch.Abstract));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-sm-12");
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "placeholder", "Objectives");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                                  oResearch.Objectives

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oResearch.Objectives = __value, oResearch.Objectives))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oResearch.Objectives));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-sm-12");
                __builder2.AddMarkupContent(90, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(91);
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "placeholder", "Results");
                __builder2.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                                  oResearch.Results

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oResearch.Results = __value, oResearch.Results))));
                __builder2.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oResearch.Results));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n        <br>\r\n\r\n");
#nullable restore
#line 74 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
         if (oAlert.Visible)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(100, "            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "alert" + " alert-" + (
#nullable restore
#line 77 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                         oAlert.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "role", "alert");
                __builder2.AddMarkupContent(107, "\r\n                    ");
                __builder2.AddContent(108, 
#nullable restore
#line 78 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                     oAlert.Message

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n");
#nullable restore
#line 81 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "type", "submit");
                __builder2.AddAttribute(118, "class", "btn btn-success btn-lg btn-block");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
                                                                                     Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(120, " Save ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Crear.razor"
       

    Research oResearch = new Research();

    Response<object> oResponse = new Response<object>();

    String Url = "/api/Research";

    String rutaInput = "";

    Alert oAlert = new Alert();

    private async Task Save()
    {

        if (validateTitle())
        {
            if (!rutaInput.Equals("")) oResearch.Picture = rutaInput.Substring(12);

            oResearch.CreateDate = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ",";
            oResearch.CreateDate += DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            var response = await Http.PostAsJsonAsync<Research>(Url, oResearch);
            oResponse = response.Content.ReadFromJsonAsync<Response<object>>().Result;

            if (oResponse.Success == 0) oAlert.isBad(oResponse.Message);

            else
            {
                oAlert.isGood("Research" + " ' " + oResearch.Title + " ' " + " Created");
                oResearch.Reset();
                rutaInput = "";
            }
        }
    }

    private Boolean validateTitle()
    {
        oResearch.Title = oResearch.Title.Trim();

        if (oResearch.Title.Equals("")) return oAlert.isBad("Field Title is required");

        return validateAbstract();
    }

    private Boolean validateAbstract()
    {
        oResearch.Abstract = oResearch.Abstract.Trim();

        if (oResearch.Abstract.Equals("")) return oAlert.isBad("Field Abstract is required");

        return validateObjectives();
    }

    private Boolean validateObjectives()
    {
        oResearch.Objectives = oResearch.Objectives.Trim();

        if (oResearch.Objectives.Equals("")) return oAlert.isBad("Field Objectives is required");

        return validateResults();
    }

    private Boolean validateResults()
    {
        oResearch.Results = oResearch.Results.Trim();

        if (oResearch.Results.Equals("")) return oAlert.isBad("Field Results is required");

        return validateBibliography();
    }

    private Boolean validateBibliography()
    {
       // oResearch.Bibliography = oResearch.Bibliography.Trim();

        // if (oResearch.Bibliography.Equals("")) return oAlert.isBad("Field Bibliography is required");

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591