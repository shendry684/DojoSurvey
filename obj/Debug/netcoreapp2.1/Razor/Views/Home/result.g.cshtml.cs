#pragma checksum "C:\Users\livei\Desktop\Coding_Dojo\CSharp_stack\DojoSurvey\Views\Home\result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98722110228a32b444e09b78b68a4671575041dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_result), @"mvc.1.0.view", @"/Views/Home/result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/result.cshtml", typeof(AspNetCore.Views_Home_result))]
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
#line 1 "C:\Users\livei\Desktop\Coding_Dojo\CSharp_stack\DojoSurvey\Views\_ViewImports.cshtml"
using DojoSurvey;

#line default
#line hidden
#line 2 "C:\Users\livei\Desktop\Coding_Dojo\CSharp_stack\DojoSurvey\Views\_ViewImports.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98722110228a32b444e09b78b68a4671575041dd", @"/Views/Home/result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67436b50a8d850d5f878261256993a0b6c9782", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 37, true);
            WriteLiteral("<h1>Submitted Info</h1>\r\n\r\n\r\n<p>Name:");
            EndContext();
            BeginContext(53, 10, false);
#line 5 "C:\Users\livei\Desktop\Coding_Dojo\CSharp_stack\DojoSurvey\Views\Home\result.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(63, 86, true);
            WriteLiteral("</p>\r\n\r\n<p>Comment@Model.Comment</p>\r\n</div>\r\n<button><a href=\"/\">Go Back</a></button>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
