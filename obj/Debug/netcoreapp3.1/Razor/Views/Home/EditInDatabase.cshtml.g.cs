#pragma checksum "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898b2eb825306c18df6d3f95920b1a06774c45a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditInDatabase), @"mvc.1.0.view", @"/Views/Home/EditInDatabase.cshtml")]
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
#line 1 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
using FirstDbExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898b2eb825306c18df6d3f95920b1a06774c45a0", @"/Views/Home/EditInDatabase.cshtml")]
    public class Views_Home_EditInDatabase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n     <html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898b2eb825306c18df6d3f95920b1a06774c45a03024", async() => {
                WriteLiteral("\r\n        <title>To Do</title>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898b2eb825306c18df6d3f95920b1a06774c45a04030", async() => {
                WriteLiteral("\r\n\r\n        <h1>Please provide information which work need to be edit and change </h1>\r\n");
#nullable restore
#line 11 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
         using (Html.BeginForm("SaveEditInDatabase", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label for=\"name\"> To do work to edit: </label>\r\n            <input type=\"text\" name=\"title\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 471, "\"", 496, 1);
#nullable restore
#line 14 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 479, Model.Todo.Title, 479, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Submit\" /><br />\r\n");
                WriteLiteral("            <label for=\"description\"> Description of work to edit: </label>\r\n            <input type=\"text\" name=\"Description\" id=\"description\" />\r\n            <input type=\"submit\" value=\"Submit\" /><br />\r\n");
                WriteLiteral("            <label for=\"urgent\"> Is it urgent?: </label>\r\n            <input type=\"checkbox\" name=\"IsUrgent\" id=\"urgent\" value=\"true\" /><br />\r\n");
                WriteLiteral("            <label for=\"done\"> Is it done?: </label>\r\n            <input type=\"checkbox\" name=\"IsDone\" id=\"done\" value=\"true\" />\r\n");
                WriteLiteral("            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1090, "\"", 1112, 1);
#nullable restore
#line 27 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 1098, Model.Todo.Id, 1098, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("            <h2>Who will do this Work?</h2>\r\n");
                WriteLiteral("            <label for=\"worker\"> Add worker: </label>\r\n            <select name=\"AsigneeId\" id=\"AsigneeId\" asp-for=\"AsigneeId\" >\r\n");
#nullable restore
#line 34 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
                 foreach (var worker in Model.Asignees)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <option");
                BeginWriteAttribute("value", " value=\"", 1402, "\"", 1420, 1);
#nullable restore
#line 36 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 1410, worker.Id, 1410, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
                                          Write(worker.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 37 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </select>\r\n");
                WriteLiteral("            <input type=\"submit\" value=\"Submit\" /><br />\r\n");
#nullable restore
#line 42 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
