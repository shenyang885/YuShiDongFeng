#pragma checksum "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29010ff1bc799447b177580ba5b20b629bc4b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Menu.cshtml", typeof(AspNetCore.Views_Home_Menu))]
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
#line 1 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29010ff1bc799447b177580ba5b20b629bc4b66", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<余氏东风.ViewModels.HomeVMs.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 74, true);
            WriteLiteral("<div class=\"layui-side-scroll\">\n    <ul class=\"layui-nav layui-nav-tree\">\n");
            EndContext();
#line 4 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
         foreach (var item in Model.Menu)
        {
            

#line default
#line hidden
#line 6 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
             if (item.Url != null)
            {

#line default
#line hidden
            BeginContext(214, 66, true);
            WriteLiteral("                <li class=\"layui-nav-item\">\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 280, "\"", 323, 3);
            WriteAttributeValue("", 287, "javascript:;ff.LoadPage(\'", 287, 25, true);
#line 9 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
WriteAttributeValue("", 312, item.Url, 312, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 321, "\')", 321, 2, true);
            EndWriteAttribute();
            BeginContext(324, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 10 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                         if (!string.IsNullOrEmpty(item.ICon))
                        {

#line default
#line hidden
            BeginContext(414, 26, true);
            WriteLiteral("<img class=\"layui-nav-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 440, "\"", 479, 2);
            WriteAttributeValue("", 446, "/_Framework/GetFile?id=", 446, 23, true);
#line 11 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
WriteAttributeValue("", 469, item.ICon, 469, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(480, 1, true);
            WriteLiteral(">");
            EndContext();
#line 11 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                            }

#line default
#line hidden
            BeginContext(483, 9, false);
#line 11 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                        Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(492, 48, true);
            WriteLiteral("\n                    </a>\n                </li>\n");
            EndContext();
#line 14 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(585, 97, true);
            WriteLiteral("                <li class=\"layui-nav-item\">\n                    <a class=\"\" href=\"javascript:;\">\n");
            EndContext();
#line 19 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                         if (!string.IsNullOrEmpty(item.ICon))
                        {

#line default
#line hidden
            BeginContext(770, 26, true);
            WriteLiteral("<img class=\"layui-nav-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 796, "\"", 835, 2);
            WriteAttributeValue("", 802, "/_Framework/GetFile?id=", 802, 23, true);
#line 20 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
WriteAttributeValue("", 825, item.ICon, 825, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(836, 1, true);
            WriteLiteral(">");
            EndContext();
#line 20 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                            }

#line default
#line hidden
            BeginContext(839, 9, false);
#line 20 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                        Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(848, 75, true);
            WriteLiteral("\n                    </a>\n                    <dl class=\"layui-nav-child\">\n");
            EndContext();
#line 23 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                         foreach (var child in item.Children)
                        {

#line default
#line hidden
            BeginContext(1011, 67, true);
            WriteLiteral("                            <dd>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1078, "\"", 1122, 3);
            WriteAttributeValue("", 1085, "javascript:;ff.LoadPage(\'", 1085, 25, true);
#line 26 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
WriteAttributeValue("", 1110, child.Url, 1110, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1120, "\')", 1120, 2, true);
            EndWriteAttribute();
            BeginContext(1123, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 27 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                     if (!string.IsNullOrEmpty(child.ICon))
                                    {

#line default
#line hidden
            BeginContext(1238, 26, true);
            WriteLiteral("<img class=\"layui-nav-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1264, "\"", 1304, 2);
            WriteAttributeValue("", 1270, "/_Framework/GetFile?id=", 1270, 23, true);
#line 28 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
WriteAttributeValue("", 1293, child.ICon, 1293, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1305, 1, true);
            WriteLiteral(">");
            EndContext();
#line 28 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                                         }

#line default
#line hidden
            BeginContext(1308, 10, false);
#line 28 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                                                                                                     Write(child.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 72, true);
            WriteLiteral("\n                                </a>\n                            </dd>\n");
            EndContext();
#line 31 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
                        }

#line default
#line hidden
            BeginContext(1416, 48, true);
            WriteLiteral("                    </dl>\n                </li>\n");
            EndContext();
#line 34 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
            }

#line default
#line hidden
#line 34 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Menu.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1488, 17, true);
            WriteLiteral("    </ul>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<余氏东风.ViewModels.HomeVMs.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
