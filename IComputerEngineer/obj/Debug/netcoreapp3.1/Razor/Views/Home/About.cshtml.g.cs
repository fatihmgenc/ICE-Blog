#pragma checksum "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21edda44df11b286cf6af96f3d57df0a0a3aa36d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\_ViewImports.cshtml"
using IComputerEngineer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\_ViewImports.cshtml"
using IComputerEngineer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\_ViewImports.cshtml"
using IComputerEngineer.Models.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\_ViewImports.cshtml"
using IComputerEngineer.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21edda44df11b286cf6af96f3d57df0a0a3aa36d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108b00fef8b40ad84d4043064262165febcf1904", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""about-section"">
    <h1>About This Blog</h1>
    <p>Some text about who we are and what we do.</p>
</div>

<h2 style=""text-align:center"">Our Team</h2>

<img class=""about-image"" src=""https://avatars2.githubusercontent.com/u/47807713?s=400&u=4deb1f71c8b8cdd9b4d57168ae606c7f04811a48&v=4"" alt=""Jane"" style=""width:100%"">
<div class=""card"">
    <div class=""container"">
        <h2>Fatih M. GENÇ</h2>
        <p class=""title"">Author</p>
        <p>Some text that describes me lorem ipsum ipsum lorem.</p>
        <p>fatihmgenc@gmail.com</p>
        <p><button class=""button"">Contact</button></p>
    </div>
</div>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
