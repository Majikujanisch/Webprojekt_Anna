#pragma checksum "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "653b2bca8b65b6fc03eb8e43f8feeb4da5e4c2bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\_ViewImports.cshtml"
using Webprojekt_Anna;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
using Webprojekt_Anna.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653b2bca8b65b6fc03eb8e43f8feeb4da5e4c2bb", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfab32af02bfa032c5bd05632fc8fd040554702", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
  
    ViewData["Title"] = "Pokemon";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Hier kannst du zu jedem Pokedex Eintrag das Pokemon Auswählen:\r\n</p>\r\n");
#nullable restore
#line 9 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Es sind keine Pokemon Vorhanden.\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tbody>\r\n            <tr>\r\n                <td>Pokedex NR</td>\r\n                <td>Name</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
             foreach (Pokemon poke in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
                   Write(poke.Pokedex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
                   Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Das waren alle Aktuellen Pokemon</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\karot\IdeaProjects\Webprojekt_Anna\Webprojekt_Anna\Views\Pokemon\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
