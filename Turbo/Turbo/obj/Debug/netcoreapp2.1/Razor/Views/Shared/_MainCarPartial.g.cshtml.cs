#pragma checksum "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96808c0487566334abf579892e724a99b43b2b13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainCarPartial), @"mvc.1.0.view", @"/Views/Shared/_MainCarPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MainCarPartial.cshtml", typeof(AspNetCore.Views_Shared__MainCarPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96808c0487566334abf579892e724a99b43b2b13", @"/Views/Shared/_MainCarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e365805f4b2aaf4cd3e29f1667ef64c90dc23bea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MainCarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Elan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "elan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productBorder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 70, true);
            WriteLiteral("<section>\r\n    <div class=\"wrapper\">\r\n        <div class=\"products\">\r\n");
            EndContext();
#line 5 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
             foreach (var item in @Model)
            {


#line default
#line hidden
            BeginContext(156, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(172, 1532, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3062e11ff6974f7e826d945954f948fc", async() => {
                BeginContext(290, 132, true);
                WriteLiteral("\r\n                    <div class=\"onliCar\">\r\n                        <i class=\"far fa-heart likeIcon\"></i>\r\n                        ");
                EndContext();
                BeginContext(422, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24549ad4526943b996b239b867e5c188", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 432, "~/images/Cars/", 432, 14, true);
#line 11 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
AddHtmlAttributeValue("", 446, item.SekilUrl, 446, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(469, 82, true);
                WriteLiteral("\r\n                        <div class=\"productPrice\">\r\n                            ");
                EndContext();
                BeginContext(552, 11, false);
#line 13 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                       Write(item.Qiymet);

#line default
#line hidden
                EndContext();
                BeginContext(563, 149, true);
                WriteLiteral("<span>AZN</span>\r\n                        </div>\r\n                        <div class=\"productsInfo\">\r\n                            <p class=\"carName\">");
                EndContext();
                BeginContext(713, 21, false);
#line 16 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                          Write(item.Model.Marka.Name);

#line default
#line hidden
                EndContext();
                BeginContext(734, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(736, 15, false);
#line 16 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                                                 Write(item.Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(751, 143, true);
                WriteLiteral("</p>\r\n                            <div class=\"carInfo\">\r\n                                <p class=\"year\">\r\n                                    ");
                EndContext();
                BeginContext(895, 19, false);
#line 19 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                               Write(item.IstehsalIli.Il);

#line default
#line hidden
                EndContext();
                BeginContext(914, 183, true);
                WriteLiteral(" il\r\n\r\n                                    <span></span>\r\n                                </p>\r\n                                <p class=\"engin\">\r\n                                    ");
                EndContext();
                BeginContext(1098, 23, false);
#line 24 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                               Write(item.MuherrikHecmi.Hecm);

#line default
#line hidden
                EndContext();
                BeginContext(1121, 139, true);
                WriteLiteral(" L\r\n                                    <span></span>\r\n                                </p>\r\n                                <p class=\"km\">");
                EndContext();
                BeginContext(1261, 18, false);
#line 27 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                         Write(item.YurusMesafesi);

#line default
#line hidden
                EndContext();
                BeginContext(1279, 130, true);
                WriteLiteral(" km </p>\r\n                            </div>\r\n                            <div class=\"enterDay\">\r\n                                ");
                EndContext();
                BeginContext(1410, 15, false);
#line 30 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                           Write(item.Seher.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1425, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1428, 42, false);
#line 30 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                             Write(item.YazilmaVaxti.ToString("dd MMMM yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1470, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                 if (item.Vip)
                                {

#line default
#line hidden
                BeginContext(1553, 26, true);
                WriteLiteral("<i class=\"fas fa-gem\"></i>");
                EndContext();
#line 32 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                                           }

#line default
#line hidden
                BeginContext(1582, 118, true);
                WriteLiteral("                            </div>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1704, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Views\Shared\_MainCarPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1721, 77, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Elan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
