#pragma checksum "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "188cedac09f883bdf05153e4ff62788ef0120dd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateAssInDB), @"mvc.1.0.view", @"/Views/Home/UpdateAssInDB.cshtml")]
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
#line 1 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"
using FirstDbExercise;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188cedac09f883bdf05153e4ff62788ef0120dd9", @"/Views/Home/UpdateAssInDB.cshtml")]
    public class Views_Home_UpdateAssInDB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignee>
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
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "188cedac09f883bdf05153e4ff62788ef0120dd92995", async() => {
                WriteLiteral("\r\n    <title>Asignee</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "188cedac09f883bdf05153e4ff62788ef0120dd93991", async() => {
                WriteLiteral("\r\n\r\n    <h1>Please provide information which work need to be edit and change </h1>\r\n");
#nullable restore
#line 11 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"
     using (Html.BeginForm("SaveUpdateInDatabase", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label for=\"name\"> Name to edit: </label>\r\n        <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 406, "\"", 425, 1);
#nullable restore
#line 14 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"
WriteAttributeValue("", 414, Model.Name, 414, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Submit\" /><br />\r\n");
                WriteLiteral("        <label for=\"email\"> E-mail edit: </label>\r\n        <input type=\"email\" name=\"email\" id=\"email\"");
                BeginWriteAttribute("value", " value=\"", 589, "\"", 609, 1);
#nullable restore
#line 18 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"
WriteAttributeValue("", 597, Model.Email, 597, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Submit\" /><br />\r\n");
                WriteLiteral("        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 709, "\"", 726, 1);
#nullable restore
#line 21 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"
WriteAttributeValue("", 717, Model.Id, 717, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 22 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\UpdateAssInDB.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignee> Html { get; private set; }
    }
}
#pragma warning restore 1591
