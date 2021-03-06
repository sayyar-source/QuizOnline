#pragma checksum "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c689ec6e7e552f4a19de1fd4912c8e1e6f87d8d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_StartQuiz), @"mvc.1.0.view", @"/Views/Quiz/StartQuiz.cshtml")]
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
#line 1 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\_ViewImports.cshtml"
using SinavOlusturma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\_ViewImports.cshtml"
using SinavOlusturma.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\_ViewImports.cshtml"
using SinavOlusturma.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\_ViewImports.cshtml"
using SinavOlusturma.Common.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c689ec6e7e552f4a19de1fd4912c8e1e6f87d8d1", @"/Views/Quiz/StartQuiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304d5aaefb26e45ed4f538fae18c4d30be273bdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_StartQuiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<style>\r\n    .bg-quizLogo {\r\n        color: #fff;\r\n        background: linear-gradient(-70deg, #045de9 0%, rgba(0, 0, 0, 0) 74%), url(\'");
#nullable restore
#line 7 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                               Write(Model.QuizUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        background-repeat: no-repeat;
        background-size: contain;
        text-align: right;
        border-top-right-radius: 1em;
        border-bottom-right-radius: 1em;
    }
    .checked {
        background-color:cornflowerblue;
    }
    .correct {
        background-color: chartreuse;
    }
    .incorrect {
        background-color:red;
    }
   
</style>

<br />
<div class=""text-center"">
    <div>
        <h3>");
#nullable restore
#line 29 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div>\r\n        <textarea class=\"d-inline-flex p-2\" id=\"quizbody\" rows=\"20\" cols=\"150\">");
#nullable restore
#line 32 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                          Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n");
#nullable restore
#line 37 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
   var questions = Model.QuizQuestions as QuestionViewModel[] ?? Model.QuizQuestions.ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
 if (Model.QuizQuestions.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"mx-auto card-holder\">\r\n        <div class=\"quizCard text-center\" style=\"width: 20em;\">\r\n            <p>Hen??z kay??tl?? sinav yok</p>\r\n           \r\n        </div>\r\n    </div>\r\n</div> \r\n");
#nullable restore
#line 49 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
}
 
else
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c689ec6e7e552f4a19de1fd4912c8e1e6f87d8d17006", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 54 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"row \">\r\n");
#nullable restore
#line 56 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
    
     var count = 0;
   
     for (var i = 0; i < questions.Length; i++)
     {
         count = i + 1;
     

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div");
            BeginWriteAttribute("id", " id=\"", 1481, "\"", 1492, 1);
#nullable restore
#line 63 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 1486, count, 1486, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-6\">\r\n                <h4>");
#nullable restore
#line 64 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 64 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                       Write(questions[i].QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c689ec6e7e552f4a19de1fd4912c8e1e6f87d8d19940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 65 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].QuestionId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                 WriteLiteral(questions[i].QuizId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <label");
            BeginWriteAttribute("id", " id=\"", 1700, "\"", 1709, 2);
            WriteAttributeValue("", 1705, "1_", 1705, 2, true);
#nullable restore
#line 66 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 1707, i, 1707, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"cursor: pointer; border: 2px solid black;min-width:100%\">A)&nbsp;");
#nullable restore
#line 66 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                                                         Write(questions[i].FirstOption);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                    <label");
            BeginWriteAttribute("id", " id=\"", 1846, "\"", 1855, 2);
            WriteAttributeValue("", 1851, "2_", 1851, 2, true);
#nullable restore
#line 67 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 1853, i, 1853, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer; border: 2px solid black;min-width:100%\">B)&nbsp;");
#nullable restore
#line 67 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                                                        Write(questions[i].SecondOption);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                    <label");
            BeginWriteAttribute("id", " id=\"", 1992, "\"", 2001, 2);
            WriteAttributeValue("", 1997, "3_", 1997, 2, true);
#nullable restore
#line 68 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 1999, i, 1999, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer; border: 2px solid black;min-width:100%\">C)&nbsp;");
#nullable restore
#line 68 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                                                        Write(questions[i].ThirdOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label");
            BeginWriteAttribute("id", " id=\"", 2136, "\"", 2145, 2);
            WriteAttributeValue("", 2141, "4_", 2141, 2, true);
#nullable restore
#line 69 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 2143, i, 2143, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer; border: 2px solid black;min-width:100%\">D)&nbsp; ");
#nullable restore
#line 69 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
                                                                                                         Write(questions[i].FourthOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>   \r\n          </div> \r\n");
#nullable restore
#line 71 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-12 text-center\">\r\n        <br />\r\n        <button class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2396, "\"", 2427, 3);
            WriteAttributeValue("", 2406, "answer(\'", 2406, 8, true);
#nullable restore
#line 76 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
WriteAttributeValue("", 2414, Model.Id, 2414, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2425, "\')", 2425, 2, true);
            EndWriteAttribute();
            WriteLiteral(">SINAVI TAMAMLA</button>\r\n");
            WriteLiteral("    </div>\r\n");
            WriteLiteral(" <div>\r\n\r\n</div>\r\n");
#nullable restore
#line 83 "C:\Users\muhammeds\Desktop\my project\SinavOlusturma\SinavOlusturma\Views\Quiz\StartQuiz.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $('label').click(function () {
        for (var i = 0; i < this.parentNode.childNodes.length; i++) {
            
            if (this.parentNode.childNodes[i].className == ""checked"") {
                labelId = this.parentNode.childNodes[i].id
                $('#' + labelId).toggleClass(""checked"")
            }
            if (this.parentNode.childNodes[i].className == ""correct"") {
                    labelId = this.parentNode.childNodes[i].id
                    $('#' + labelId).toggleClass(""correct"")
            }
            if (this.parentNode.childNodes[i].className == ""incorrect"") {
                labelId = this.parentNode.childNodes[i].id
                $('#' + labelId).toggleClass(""incorrect"")
            }
        }
    $(this).toggleClass(""checked"")   
    });
    function answer(quizid)
    {
        $.ajax({
            url: ""/Quiz/GetQuizById"",
            type: ""GET"",
            data: { quizId: quizid },
            traditional: true,
            succe");
            WriteLiteral(@"ss: function (result) {
                for (var i = 0; i < result.quizQuestions.length; i++) {
                    var doc = document.getElementById(i + 1);
                    for (var j = 0; j < doc.childNodes.length; j++) {
                        if (doc.childNodes[j].className == ""checked"") {
                            lblId = doc.childNodes[j].id.substring(0, 1);
                            correctAnswer = result.quizQuestions[i].correctAnswer
                            if (lblId == correctAnswer) {
                                $('#' + doc.childNodes[j].id).toggleClass(""checked"")
                                $('#' + doc.childNodes[j].id).toggleClass(""correct"")
                            }
                            else {
                                $('#' + doc.childNodes[j].id).toggleClass(""checked"")
                                $('#' + doc.childNodes[j].id).toggleClass(""incorrect"")
                            }
                        }
                    }      
  ");
            WriteLiteral("              }\r\n            },\r\n            error: function () {\r\n                alert(\"Something went wrong\");\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
