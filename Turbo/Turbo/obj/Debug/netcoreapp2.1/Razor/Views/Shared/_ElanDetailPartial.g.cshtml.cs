#pragma checksum "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a144a10ae66f575391e85df3aa2a55f4efecac64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ElanDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_ElanDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ElanDetailPartial.cshtml", typeof(AspNetCore.Views_Shared__ElanDetailPartial))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\_ViewImports.cshtml"
using Turbo;

#line default
#line hidden
#line 2 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\_ViewImports.cshtml"
using Turbo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a144a10ae66f575391e85df3aa2a55f4efecac64", @"/Views/Shared/_ElanDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e365805f4b2aaf4cd3e29f1667ef64c90dc23bea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ElanDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turbo.Models.Elan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover;height:400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover;height:200px;width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:20px; width:100%;margin-top:50px;margin-bottom:50px;display:inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "elan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Markalar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Modeller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "doconform", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#line 6 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
 if (TempData["DoConformed"] != null)
{

#line default
#line hidden
            BeginContext(112, 59, true);
            WriteLiteral("    <h4 class=\"alert alert-success\">Elan tesdiqlendi</h4>\r\n");
            EndContext();
#line 9 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
}

#line default
#line hidden
            BeginContext(174, 119, true);
            WriteLiteral("<div class=\"wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h4>Sekiller</h4>\r\n            ");
            EndContext();
            BeginContext(293, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd41eae71d7a45a3998333f18a65adbc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 341, "~/images/Cars/", 341, 14, true);
#line 14 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
AddHtmlAttributeValue("", 355, Model.SekilUrl, 355, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 57, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
         foreach (var sekil in Model.Sekiller)
        {

#line default
#line hidden
            BeginContext(490, 49, true);
            WriteLiteral("            <div class=\"col-4\">\r\n                ");
            EndContext();
            BeginContext(539, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dc1ea0e7106439aa597354cff06affc", async() => {
                BeginContext(680, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(702, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1997bc046f2429897c906e8606b7fca", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 761, "~/images/Cars/", 761, 14, true);
#line 24 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
AddHtmlAttributeValue("", 775, sekil.Name, 775, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(790, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 653, "~/images/Cars/", 653, 14, true);
#line 23 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
AddHtmlAttributeValue("", 667, sekil.Name, 667, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 27 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(845, 213, true);
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        <style>\r\n            .detal p {\r\n                padding: 0px\r\n            }\r\n        </style>\r\n        <div class=\"col-12\">\r\n            <h2 style=\"padding-bottom:40px\">");
            EndContext();
            BeginContext(1059, 22, false);
#line 36 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                       Write(Model.Model.Marka.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1083, 16, false);
#line 36 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                               Write(Model.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 88, true);
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-6 detal\">\r\n\r\n            <p><b>Seher</b>:");
            EndContext();
            BeginContext(1188, 16, false);
#line 40 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                       Write(Model.Seher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 34, true);
            WriteLiteral("</p>\r\n            <p><b>Marka</b>:");
            EndContext();
            BeginContext(1238, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0812fcd5af37484cbfec2bb6e6e79cf3", async() => {
                BeginContext(1323, 22, false);
#line 41 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                                                           Write(Model.Model.Marka.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                             WriteLiteral(Model.Model.Marka.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 35, true);
            WriteLiteral(" </p>\r\n            <p><b>Model</b>:");
            EndContext();
            BeginContext(1384, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5491602b09549089370463383266683", async() => {
                BeginContext(1463, 16, false);
#line 42 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                                                     Write(Model.Model.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                             WriteLiteral(Model.Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 37, true);
            WriteLiteral("</p>\r\n            <p><b>Ban novu</b>:");
            EndContext();
            BeginContext(1521, 18, false);
#line 43 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                          Write(Model.BanNovu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 40, true);
            WriteLiteral("</p>\r\n            <p><b>Istehsa ili</b>:");
            EndContext();
            BeginContext(1580, 20, false);
#line 44 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                             Write(Model.IstehsalIli.Il);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 43, true);
            WriteLiteral("</p>\r\n            <p><b>Muherrik hecmi</b>:");
            EndContext();
            BeginContext(1644, 24, false);
#line 45 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                Write(Model.MuherrikHecmi.Hecm);

#line default
#line hidden
            EndContext();
            BeginContext(1668, 36, true);
            WriteLiteral("</p>\r\n            <p><b>Oturucu</b>:");
            EndContext();
            BeginContext(1705, 18, false);
#line 46 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                         Write(Model.Oturucu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 34, true);
            WriteLiteral("</p>\r\n            <p><b>Rengi</b>:");
            EndContext();
            BeginContext(1758, 15, false);
#line 47 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                       Write(Model.Reng.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 41, true);
            WriteLiteral("</p>\r\n            <p><b>Suret qutusu</b>:");
            EndContext();
            BeginContext(1815, 22, false);
#line 48 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                              Write(Model.SuretQutusu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 94, true);
            WriteLiteral("</p>\r\n\r\n        </div>\r\n        <div class=\"col-6 detal\">\r\n            <p><b>Yanacaq novu</b>:");
            EndContext();
            BeginContext(1932, 22, false);
#line 52 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                              Write(Model.YanacaqNovu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 43, true);
            WriteLiteral("</p>\r\n            <p><b>Yurus mesafesi</b>:");
            EndContext();
            BeginContext(1998, 19, false);
#line 53 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                Write(Model.YurusMesafesi);

#line default
#line hidden
            EndContext();
            BeginContext(2017, 45, true);
            WriteLiteral(" km</p>\r\n            <p><b>Yazilma vaxti</b>:");
            EndContext();
            BeginContext(2063, 43, false);
#line 54 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                               Write(Model.YazilmaVaxti.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 35, true);
            WriteLiteral("</p>\r\n            <p><b>Qiymet</b>:");
            EndContext();
            BeginContext(2142, 12, false);
#line 55 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                        Write(Model.Qiymet);

#line default
#line hidden
            EndContext();
            BeginContext(2154, 48, true);
            WriteLiteral(" manat</p>\r\n            <p><b>Muherrik gucu</b>:");
            EndContext();
            BeginContext(2203, 18, false);
#line 56 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                               Write(Model.MuherrikGucu);

#line default
#line hidden
            EndContext();
            BeginContext(2221, 75, true);
            WriteLiteral(" a.g</p>\r\n\r\n            <p><b>Elaqe</b></p>\r\n            <p><i>Telofon</i>:");
            EndContext();
            BeginContext(2297, 22, false);
#line 59 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                         Write(Model.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2319, 36, true);
            WriteLiteral("</p>\r\n            <p><i>Email</i>:<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2355, "\"", 2387, 2);
            WriteAttributeValue("", 2362, "https://", 2362, 8, true);
#line 60 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
WriteAttributeValue("", 2370, Model.User.Email, 2370, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2388, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2390, 16, false);
#line 60 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                           Write(Model.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2406, 86, true);
            WriteLiteral("</a></p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Melumat</b>:");
            EndContext();
            BeginContext(2493, 13, false);
#line 63 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                         Write(Model.Melumat);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 52, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n");
            EndContext();
#line 66 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
             if (Model.Register == false)
            {

#line default
#line hidden
            BeginContext(2616, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2632, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f121404d241405793e3fce7a9234e3d", async() => {
                BeginContext(2729, 14, true);
                WriteLiteral("Elani tesdiqle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2747, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 69 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2764, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 70 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
             if (User.Identity.Name == Model.User.UserName)
            {

#line default
#line hidden
            BeginContext(2840, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2856, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d75ce40d994e1a88eafe3536dc93b4", async() => {
                BeginContext(2948, 12, true);
                WriteLiteral("Elani yenile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2964, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2981, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 74 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
             if (User.Identity.Name == Model.User.UserName)
            {

#line default
#line hidden
            BeginContext(3057, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3073, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d2e78cc39448ad89afed502de9ff09", async() => {
                BeginContext(3166, 9, true);
                WriteLiteral("Elani sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3179, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 77 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_ElanDetailPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(3196, 44, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Turbo.Models.Elan> Html { get; private set; }
    }
}
#pragma warning restore 1591