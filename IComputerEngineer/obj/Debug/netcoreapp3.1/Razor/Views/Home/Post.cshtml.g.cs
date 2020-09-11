#pragma checksum "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4903ecf0e621aeb7ddaf4b50c4bf1630891062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4903ecf0e621aeb7ddaf4b50c4bf1630891062", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108b00fef8b40ad84d4043064262165febcf1904", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
  
    ViewBag.Title = "IComputerEngineer Blog";
    ViewBag.Category = Model.Category;
    ViewBag.Description = Model.Description;
    ViewBag.Tags = Model.Tags.Replace(' ', ',') + " " + Model.Category;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"post no-shadow\">\r\n");
#nullable restore
#line 11 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"post-img\"");
            BeginWriteAttribute("src", " src=\"", 426, "\"", 489, 1);
#nullable restore
#line 13 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
WriteAttributeValue("", 432, Url.Action("Image", "Home", new { image = Model.Image }), 432, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <span class=\"title\">");
#nullable restore
#line 14 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 15 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"post-body\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
   Write(Html.Raw(@Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"comment-section\">\r\n");
#nullable restore
#line 21 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
           await Html.RenderPartialAsync("_MainComment", new CommentViewModel
            {
                PostId = Model.Id,
                MainCommentId = 0
            });
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
         foreach (var c in Model.MainComments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 30 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
           Write(c.Messege);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ---- ");
#nullable restore
#line 30 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                           Write(c.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div style=\"margin-left:20px;\">\r\n                <h4>Sub Comments</h4>\r\n");
#nullable restore
#line 34 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                  
                    await Html.RenderPartialAsync("_MainComment", new CommentViewModel
                    {
                        PostId = Model.Id,
                        MainCommentId = c.Id,
                    });
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                 foreach (var sc in c.SubComments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        ");
#nullable restore
#line 44 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                   Write(sc.Messege);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ---- ");
#nullable restore
#line 44 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
                                    Write(sc.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("     \r\n                    </p>\r\n");
#nullable restore
#line 46 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 49 "C:\Users\Fatih\source\repos\IComputerEngineer\IComputerEngineer\Views\Home\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
