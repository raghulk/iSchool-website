#pragma checksum "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82a9125cfbcac7067e5eb46bc31011e43738dbbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFaculty), @"mvc.1.0.view", @"/Views/Home/GetFaculty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a9125cfbcac7067e5eb46bc31011e43738dbbe", @"/Views/Home/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.FacultyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/base/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
  
    ViewData["Title"] = "Faculty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
 for (var i = 0; i < Model.Faculty.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row position-relative pt-3\">\r\n        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 290, "", 332, 1);
#nullable restore
#line 13 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 294, String.Concat("myDiv:", i.ToString()), 294, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 377, "\"", 410, 1);
#nullable restore
#line 14 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 383, Model.Faculty[i].imagePath, 383, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px;cursor:pointer\"");
            BeginWriteAttribute("alt", " alt=\"", 459, "\"", 465, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 935, "", 977, 1);
#nullable restore
#line 33 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 939, String.Concat("myDiv:", i.ToString()), 939, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1022, "\"", 1055, 1);
#nullable restore
#line 34 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1028, Model.Faculty[i].imagePath, 1028, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px;cursor:pointer\"");
            BeginWriteAttribute("alt", " alt=\"", 1104, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1580, "", 1622, 1);
#nullable restore
#line 53 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1584, String.Concat("myDiv:", i.ToString()), 1584, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1667, "\"", 1700, 1);
#nullable restore
#line 54 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1673, Model.Faculty[i].imagePath, 1673, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px;cursor:pointer\"");
            BeginWriteAttribute("alt", " alt=\"", 1749, "\"", 1755, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 2225, "", 2267, 1);
#nullable restore
#line 73 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 2229, String.Concat("myDiv:", i.ToString()), 2229, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2312, "\"", 2345, 1);
#nullable restore
#line 74 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 2318, Model.Faculty[i].imagePath, 2318, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px;cursor:pointer\"");
            BeginWriteAttribute("alt", " alt=\"", 2394, "\"", 2400, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div>&nbsp;</div>\r\n        <div>&nbsp;</div>\r\n    </div>\r\n");
#nullable restore
#line 85 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"dialog\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a9125cfbcac7067e5eb46bc31011e43738dbbe14666", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82a9125cfbcac7067e5eb46bc31011e43738dbbe15706", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a9125cfbcac7067e5eb46bc31011e43738dbbe16822", async() => {
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
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var facultyData = ");
#nullable restore
#line 93 "C:\Users\Raghul Krishnan\Desktop\ISTE340\ISTE340\Lecture25_EverythingYouNeedToKnowForProject3\Project3EnahncedCode\Project3_FinalExam\Views\Home\GetFaculty.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.Faculty)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getName(id) {
        console.log(facultyData);
        let facultyElement = (id).split(':')[1];

        var divContent = ""<div><ul>"";

        divContent += ""<li><font color='#18ADEA'><b><u>Title:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].title + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].email + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";

        divContent += ""</ul></div>"";

        let elmnt = document.getElementById(id);
        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: facultyData[facultyElement].name,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt },
            buttons: [
                {
                 ");
            WriteLiteral(@"   text: ""OK"",
                    icons: {
                        primary: ""ui-icon-heart""
                    },
                    click: function () {
                        $j(""#dialog"").dialog(""close"");
                    }
                }
            ]
        });
        $j(""#dialog"").dialog(""open"")
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.FacultyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
