#pragma checksum "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1cfdf70fbc63a7e5d59c564ad4fd71213b78efc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cfdf70fbc63a7e5d59c564ad4fd71213b78efc", @"/Views/Moon/MoonResults.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b46c789d1bd4f089209ce64ad8173ab", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61cdd30b602349d6b932f0600fd1755b", async() => {
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
            BeginContext(154, 23, true);
            WriteLiteral("\r\n\r\n<h1>Results:</h1>\r\n");
            EndContext();
#line 7 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
   
    foreach(KeyValuePair<string, Ore> moon in @Model.moonInfo) {

#line default
#line hidden
            BeginContext(284, 12, true);
            WriteLiteral("        <h5>");
            EndContext();
            BeginContext(297, 8, false);
#line 9 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
       Write(moon.Key);

#line default
#line hidden
            EndContext();
            BeginContext(305, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(314, 351, true);
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
            BeginContext(765, 53, true);
            WriteLiteral("                    <tr>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 818, "\"", 834, 1);
#line 24 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 826, ore.Key, 826, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(835, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(837, 7, false);
#line 24 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                        Write(ore.Key);

#line default
#line hidden
            EndContext();
            BeginContext(844, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 878, "\"", 896, 1);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 886, ore.Value, 886, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(899, 9, false);
#line 25 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                          Write(ore.Value);

#line default
#line hidden
            EndContext();
            BeginContext(908, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 942, "\"", 970, 3);
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 947, ore.Key, 947, 8, false);

#line default
#line hidden
#line 26 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue(" ", 955, ore.Value, 956, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 966, "Raw", 967, 4, true);
            EndWriteAttribute();
            BeginContext(971, 38, true);
            WriteLiteral(">N/A</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1009, "\"", 1041, 3);
#line 27 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 1014, ore.Key, 1014, 8, false);

#line default
#line hidden
#line 27 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue(" ", 1022, ore.Value, 1023, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1033, "Refined", 1034, 8, true);
            EndWriteAttribute();
            BeginContext(1042, 47, true);
            WriteLiteral(">N/A</td> \r\n                    </tr>        \r\n");
            EndContext();
#line 29 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                }
             

#line default
#line hidden
            BeginContext(1127, 40, true);
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
