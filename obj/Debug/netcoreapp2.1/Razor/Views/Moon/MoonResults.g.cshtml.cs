#pragma checksum "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf3aff830f511fd0f6a7b83867d23a74410629a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf3aff830f511fd0f6a7b83867d23a74410629a", @"/Views/Moon/MoonResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd879b8937f11a721e420698aaf1ef4761734ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Moon_MoonResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoonCalculator.Models.Moon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 88, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    $(document).ready(function() {\r\n        var scan = ");
            EndContext();
            BeginContext(89, 22, false);
#line 3 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
              Write(Json.Serialize(@Model));

#line default
#line hidden
            EndContext();
            BeginContext(111, 4455, true);
            WriteLiteral(@";
        var jitaPrice;
        var unrefinedValue;
        console.log(scan);
        const m3Month = 13440000;

        function itemID(ore) {
            const typeIDs = {
                ""Bitumens"" : 45492,
                ""Brilliant Gneiss"" : 46679,
                ""Chromite"" : 45501,
                ""Cinnabar"" : 45506,
                ""Cobaltite"" : 45494,
                ""Coesite"" : 45493,
                ""Cubic Bistot"" : 46676,
                ""Dazzling Spodumain"" : 46688,
                ""Euxenite"" : 45495,
                ""Flawless Arkonor"" : 46678,
                ""Glossy Scordite"" : 46687,
                ""Immaculate Jaspet"" : 46682,
                ""Jet Ochre"" : 46675,
                ""Loparite"" : 45512,
                ""Lustrous Hedbergite"" : 46680,
                ""Monazite"" : 45511,
                ""Opulent Pyroxeres"" : 46686,
                ""Otavite"" : 45498,
                ""Platinoid Omber"" : 46684,
                ""Pellucid Crokite"" : 46677,
                ""Po");
            WriteLiteral(@"llucite"" : 45504,
                ""Resplendant Kernite"" : 46683,
                ""Scheelite"" : 45497,
                ""Scintilatting Hemorphite"" : 46681,
                ""Sparkling Plagioclase"" : 46685,
                ""Sperrylite"" : 45499,
                ""Stable Veldspar"" : 46689,
                ""Sylvite"" : 45491,
                ""Titanite"" : 45496,
                ""Vanadinite"" : 45500,
                ""Xenotime"" : 45510,
                ""Ytterbite"" : 45513,
                ""Zeolites"" : 45490,
                ""Zircon"" : 45503                
            }
            return typeIDs[ore];
        }

        function m3PerUnit(ore) {
            const orem3 = {
                ""Bitumens"" : 10,
                ""Brilliant Gneiss"" : 5,
                ""Chromite"" : 10,
                ""Cinnabar"" : 10,
                ""Cobaltite"" : 10,
                ""Coesite"" : 10,
                ""Cubic Bistot"" : 16,
                ""Dazzling Spodumain"" : 16,
                ""Euxenite"" : 10,
      ");
            WriteLiteral(@"          ""Flawless Arkonor"" : 16,
                ""Glossy Scordite"" : 0.15,
                ""Immaculate Jaspet"" : 2,
                ""Jet Ochre"" : 8,
                ""Loparite"" : 10,
                ""Lustrous Hedbergite"" : 3,
                ""Monazite"" : 10,
                ""Opulent Pyroxeres"" : 0.30,
                ""Otavite"" : 10,
                ""Platinoid Omber"" : 0.60,
                ""Pellucid Crokite"" : 16,
                ""Pollucite"" : 10,
                ""Resplendant Kernite"" : 1.20,
                ""Scheelite"" : 10,
                ""Scintilatting Hemorphite"" : 3,
                ""Sparkling Plagioclase"" : 0.35,
                ""Sperrylite"" : 10,
                ""Stable Veldspar"" : 0.10,
                ""Sylvite"" : 10,
                ""Titanite"" : 10,
                ""Vanadinite"" : 10,
                ""Xenotime"" : 10,
                ""Ytterbite"" : 10,
                ""Zeolites"" : 10,
                ""Zircon"" : 10     
            }
            return orem3[ore];
        }
");
            WriteLiteral(@"
        //console.log(scan.moonInfo[""Balle III - Moon 8""].oreInfo);

        for(var moonInfo in scan) {
            //console.log(key + "" : "" + scan[key]);
            for(var ore in scan[moonInfo]) {
                //console.log(ore + "" : "" + scan[key][ore]);
                var oreInfo = scan[moonInfo][ore];
                for(trash in oreInfo) {
                    var realOreInfo = oreInfo[trash];
                    for(oreType in realOreInfo) {
                        //console.log(oreType + "": "" + realOreInfo[oreType]);
                        var id = itemID(oreType);
                        //console.log(itemID(oreType));

                        $.get(""https://market.fuzzwork.co.uk/aggregates/?region=10000002&types="" + id, function(data) {
                            jitaPrice = data[id].sell.weightedAverage;
                            unrefinedValue = ((m3Month*realOreInfo[oreType]) / m3PerUnit(oreType)) * jitaPrice;
                            console.log(oreType + "": "" + ji");
            WriteLiteral(@"taPrice);
                            console.log(unrefinedValue);
                            document.getElementById(oreType + "" "" + realOreInfo[oreType]).innerHTML = unrefinedValue;
                        });

                        
                    }
                }
            }
        }
    });


</script>


<h1>Success</h1>
");
            EndContext();
#line 124 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
   
    foreach(KeyValuePair<string, Ore> moon in @Model.moonInfo) {

#line default
#line hidden
            BeginContext(4673, 12, true);
            WriteLiteral("        <h5>");
            EndContext();
            BeginContext(4686, 8, false);
#line 126 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
       Write(moon.Key);

#line default
#line hidden
            EndContext();
            BeginContext(4694, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(4703, 352, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Ore</th>
                    <th scope=""col"">Quantity</th>
                    <th scope=""col"">Prerefined Value</th>
                    <th scope=""col"">Refined Value</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 138 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
               
                foreach(KeyValuePair<string, string> ore in moon.Value.oreInfo) {

#line default
#line hidden
            BeginContext(5155, 53, true);
            WriteLiteral("                    <tr>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5208, "\"", 5224, 1);
#line 141 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 5216, ore.Key, 5216, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5225, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5227, 7, false);
#line 141 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                        Write(ore.Key);

#line default
#line hidden
            EndContext();
            BeginContext(5234, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5268, "\"", 5286, 1);
#line 142 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 5276, ore.Value, 5276, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5287, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5289, 9, false);
#line 142 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                                          Write(ore.Value);

#line default
#line hidden
            EndContext();
            BeginContext(5298, 34, true);
            WriteLiteral("</td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5332, "\"", 5356, 2);
#line 143 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue("", 5337, ore.Key, 5337, 8, false);

#line default
#line hidden
#line 143 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
WriteAttributeValue(" ", 5345, ore.Value, 5346, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5357, 101, true);
            WriteLiteral(">Placeholder</td>\r\n                        <td>Placeholder</td> \r\n                    </tr>        \r\n");
            EndContext();
#line 146 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
                }
             

#line default
#line hidden
            BeginContext(5496, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 150 "C:\Users\KyleE\Documents\Personal\MoonCalculator\Views\Moon\MoonResults.cshtml"
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
