#pragma checksum "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02156fdedb69e4b6ec795a22363200d55416ea05"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02156fdedb69e4b6ec795a22363200d55416ea05", @"/Views/Moon/MoonResults.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e121cc5549416d97628eaab2fbe770", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bfdffb7f4804af5b210b9a40c842e7d", async() => {
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
            BeginContext(154, 24, true);
            WriteLiteral("\r\n\r\n\r\n<h1>Success</h1>\r\n");
            EndContext();
#line 8 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
   
    foreach(KeyValuePair<string, Ore> moon in @Model.moonInfo) {

#line default
#line hidden
            BeginContext(285, 12, true);
            WriteLiteral("        <h5>");
            EndContext();
            BeginContext(298, 8, false);
#line 10 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
       Write(moon.Key);

#line default
#line hidden
            EndContext();
            BeginContext(306, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(315, 351, true);
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
#line 22 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
               
                foreach(KeyValuePair<string, string> ore in moon.Value.oreInfo) {

#line default
#line hidden
            BeginContext(766, 53, true);
            WriteLiteral("                    <tr>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 819, "\"", 835, 1);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 827, ore.Key, 827, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(836, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(838, 7, false);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                        Write(ore.Key);

#line default
#line hidden
            EndContext();
            BeginContext(845, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 879, "\"", 897, 1);
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 887, ore.Value, 887, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(898, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(900, 9, false);
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                          Write(ore.Value);

#line default
#line hidden
            EndContext();
            BeginContext(909, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 943, "\"", 967, 2);
#line 27 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 948, ore.Key, 948, 8, false);

#line default
#line hidden
#line 27 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue(" ", 956, ore.Value, 957, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(968, 85, true);
            WriteLiteral(">N/A</td>\r\n                        <td>N/A</td> \r\n                    </tr>        \r\n");
            EndContext();
#line 30 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                }
             

#line default
#line hidden
            BeginContext(1091, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 34 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
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
