#pragma checksum "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "770de4a18edd598a571e12421c59c4f14fa65441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Under), @"mvc.1.0.view", @"/Views/Home/Under.cshtml")]
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
#line 1 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770de4a18edd598a571e12421c59c4f14fa65441", @"/Views/Home/Under.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Under : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.UndergradViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/le-frog/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n<div id=\"myUnderDegrees\"></div>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
 foreach (var under in Model.UnderGrads)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3");
            BeginWriteAttribute("id", " id=", 175, "", 221, 1);
#nullable restore
#line 11 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
WriteAttributeValue("", 179, String.Concat("myHdng", under.degreeName), 179, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 11 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
                                                    Write(under.degreeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=", 263, "", 308, 1);
#nullable restore
#line 13 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
WriteAttributeValue("", 267, String.Concat("myDiv", under.degreeName), 267, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p>");
#nullable restore
#line 14 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
      Write(under.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 15 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
      Write(under.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <ul>\r\n");
#nullable restore
#line 17 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
             foreach (var conc in @under.concentrations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 19 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
               Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Under.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "770de4a18edd598a571e12421c59c4f14fa654418719", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "770de4a18edd598a571e12421c59c4f14fa654419758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "770de4a18edd598a571e12421c59c4f14fa6544110873", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
// Create Accordion
    let headings = document.querySelectorAll(""h3"");
    let divs = document.querySelectorAll(""[id^='myDiv']"");

    for (var i = 0; i < headings.length; i++) {
        $(""#myUnderDegrees"").append($(""#"" + headings[i].id));
        $(""#myUnderDegrees"").append($(""#"" + divs[i].id));
    }

    $('#myUnderDegrees').accordion({
        collapsible: true,
        active: false,
        heightStyle: ""content""
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.UndergradViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591