#pragma checksum "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f402a71b7de8562c0e65ca99633069009fb67f6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moon_MoonResults), @"mvc.1.0.view", @"/Views/Moon/MoonResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Moon/MoonResults.cshtml", typeof(AspNetCore.Views_Moon_MoonResults))]
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
#line 1 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\_ViewImports.cshtml"
using MoonCalculator;

#line default
#line hidden
#line 2 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\_ViewImports.cshtml"
using MoonCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f402a71b7de8562c0e65ca99633069009fb67f6d", @"/Views/Moon/MoonResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd879b8937f11a721e420698aaf1ef4761734ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Moon_MoonResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoonCalculator.Models.Moon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/helperFunctions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/calculatedOreValues.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<script>var scan = ");
            EndContext();
            BeginContext(20, 22, false);
#line 1 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
              Write(Json.Serialize(@Model));

#line default
#line hidden
            EndContext();
            BeginContext(42, 12, true);
            WriteLiteral(";</script>\r\n");
            EndContext();
            BeginContext(54, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef1e89bed14e473ab1a0f9f2072e1a4f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80fa3e421d3d45889a0dcba32e026cf6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(154, 22, true);
            WriteLiteral("\r\n\r\n<h1>Success</h1>\r\n");
            EndContext();
#line 7 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
   
    foreach(KeyValuePair<string, Ore> moon in @Model.moonInfo) {

#line default
#line hidden
            BeginContext(283, 12, true);
            WriteLiteral("        <h5>");
            EndContext();
            BeginContext(296, 8, false);
#line 9 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
       Write(moon.Key);

#line default
#line hidden
            EndContext();
            BeginContext(304, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(313, 351, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Ore</th>
                    <th scope=""col"">Quantity</th>
                    <th scope=""col"">Unrefined Value</th>
                    <th scope=""col"">Refined Value</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
               
                foreach(KeyValuePair<string, string> ore in moon.Value.oreInfo) {

#line default
#line hidden
            BeginContext(764, 53, true);
            WriteLiteral("                    <tr>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 817, "\"", 833, 1);
#line 24 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 825, ore.Key, 825, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(834, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(836, 7, false);
#line 24 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                        Write(ore.Key);

#line default
#line hidden
            EndContext();
            BeginContext(843, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 877, "\"", 895, 1);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 885, ore.Value, 885, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(896, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(898, 9, false);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                          Write(ore.Value);

#line default
#line hidden
            EndContext();
            BeginContext(907, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 941, "\"", 965, 2);
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 946, ore.Key, 946, 8, false);

#line default
#line hidden
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue(" ", 954, ore.Value, 955, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(966, 85, true);
            WriteLiteral(">N/A</td>\r\n                        <td>N/A</td> \r\n                    </tr>        \r\n");
            EndContext();
#line 29 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                }
             

#line default
#line hidden
            BeginContext(1089, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 33 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoonCalculator.Models.Moon> Html { get; private set; }
    }
}
#pragma warning restore 1591
