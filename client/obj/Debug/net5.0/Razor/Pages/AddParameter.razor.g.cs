#pragma checksum "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "087e133260126928f7be72d69becf15987195eb5"
// <auto-generated/>
#pragma warning disable 1591
namespace Sde3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\Radzen\SDE3\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\Radzen\SDE3\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Sde3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\Radzen\SDE3\client\_Imports.razor"
using Sde3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
using Sde3.Models.Sde;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-parameter/{ExtractId}")]
    public partial class AddParameter : Sde3.Pages.AddParameterComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Sde3.Models.Sde.Parameter>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Sde3.Models.Sde.Parameter>(
#nullable restore
#line 12 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                   parameter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                         parameter != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Sde3.Models.Sde.Parameter>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Sde3.Models.Sde.Parameter>(this, 
#nullable restore
#line 12 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                                        Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Extract");
                    __builder3.AddAttribute(19, "Component", "ExtractId");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.Sde3.Client.Pages.AddParameter.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 24, 25, 
#nullable restore
#line 20 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                               getExtractsForExtractIdResult

#line default
#line hidden
#nullable disable
                    , 26, "Name", 27, "ExtractId", 28, "Choose Extract", 29, 
#nullable restore
#line 20 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                                                                                     false

#line default
#line hidden
#nullable disable
                    , 30, "display: block; width: 100%", 31, "ExtractId", 32, 
#nullable restore
#line 20 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                                                                                                                                               parameter.ExtractId

#line default
#line hidden
#nullable disable
                    , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parameter.ExtractId = __value, parameter.ExtractId)), 34, () => parameter.ExtractId);
                    __builder3.AddMarkupContent(35, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(36);
                    __builder3.AddAttribute(37, "Component", "ExtractId");
                    __builder3.AddAttribute(38, "Text", "ExtractId is required");
                    __builder3.AddAttribute(39, "style", "position: absolute");
                    __builder3.AddAttribute(40, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                                                     0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(44, "class", "row");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(47);
                    __builder3.AddAttribute(48, "Text", "Name");
                    __builder3.AddAttribute(49, "Component", "Name");
                    __builder3.AddAttribute(50, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\n              ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(54);
                    __builder3.AddAttribute(55, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 32 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                          10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(57, "Name", "Name");
                    __builder3.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                 parameter.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parameter.Name = __value, parameter.Name))));
                    __builder3.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => parameter.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(62);
                    __builder3.AddAttribute(63, "Component", "Name");
                    __builder3.AddAttribute(64, "Text", "Name is required");
                    __builder3.AddAttribute(65, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(69, "class", "row");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(72);
                    __builder3.AddAttribute(73, "Text", "Alias");
                    __builder3.AddAttribute(74, "Component", "Alias");
                    __builder3.AddAttribute(75, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n              ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(79);
                    __builder3.AddAttribute(80, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 44 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(82, "Name", "Alias");
                    __builder3.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                 parameter.Alias

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parameter.Alias = __value, parameter.Alias))));
                    __builder3.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => parameter.Alias));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(87);
                    __builder3.AddAttribute(88, "Component", "Alias");
                    __builder3.AddAttribute(89, "Text", "Alias is required");
                    __builder3.AddAttribute(90, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(94, "class", "row");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(97);
                    __builder3.AddAttribute(98, "Text", "Description");
                    __builder3.AddAttribute(99, "Component", "Description");
                    __builder3.AddAttribute(100, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(104);
                    __builder3.AddAttribute(105, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 56 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                          100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "style", "width: 100%");
                    __builder3.AddAttribute(107, "Name", "Description");
                    __builder3.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                  parameter.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parameter.Description = __value, parameter.Description))));
                    __builder3.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => parameter.Description));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "row");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(116);
                    __builder3.AddAttribute(117, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 62 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "Icon", "save");
                    __builder3.AddAttribute(119, "Text", "Save");
                    __builder3.AddAttribute(120, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 62 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(122);
                    __builder3.AddAttribute(123, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 64 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(125, "Text", "Cancel");
                    __builder3.AddAttribute(126, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\src\Radzen\SDE3\client\Pages\AddParameter.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Sde3.Client.Pages.AddParameter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, System.Object __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "style", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
