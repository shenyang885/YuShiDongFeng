#pragma checksum "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "255cc73e54558b391efcfc9d603f2ba751c93f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Header), @"mvc.1.0.view", @"/Views/Home/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Header.cshtml", typeof(AspNetCore.Views_Home_Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255cc73e54558b391efcfc9d603f2ba751c93f2d", @"/Views/Home/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalkingTec.Mvvm.Core.BaseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/Login/ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "修改密码", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/_CodeGen/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "代码生成器", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("window-title", "代码生成器", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.LinkButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 218, true);
            WriteLiteral("\n<div class=\"layui-logo\" style=\"width:300px\"><img src=\"/logo.png\" width=\"48\" />WalkingTec.Mvvm Framework</div>\n\n<ul class=\"layui-nav layui-layout-right\">\n    <li class=\"layui-nav-item\">\n        <a href=\"javascript:;\">\n");
            EndContext();
#line 8 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
             if (Model.LoginUserInfo.PhotoId == null)
            {

#line default
#line hidden
            BeginContext(321, 70, true);
            WriteLiteral("                <img src=\"http://t.cn/RCzsdCq\" class=\"layui-nav-img\">\n");
            EndContext();
#line 11 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(436, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 456, "\"", 525, 3);
            WriteAttributeValue("", 462, "/_Framework/GetFile?id=", 462, 23, true);
#line 14 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
WriteAttributeValue("", 485, Model.LoginUserInfo.PhotoId, 485, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 513, "&stream=true", 513, 12, true);
            EndWriteAttribute();
            BeginContext(526, 24, true);
            WriteLiteral(" class=\"layui-nav-img\">\n");
            EndContext();
#line 15 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
            }

#line default
#line hidden
            BeginContext(564, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(577, 24, false);
#line 16 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
       Write(Model.LoginUserInfo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(601, 84, true);
            WriteLiteral("\n        </a>\n        <dl class=\"layui-nav-child\">\n            <dd>\n                ");
            EndContext();
            BeginContext(685, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:linkbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "255cc73e54558b391efcfc9d603f2ba751c93f2d6508", async() => {
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.LinkButtonTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper);
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Url = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.WindowWidth = 400;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("window-width", __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.WindowWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Text = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 20 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.IsLink = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("is-link", __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.IsLink, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(776, 133, true);
            WriteLiteral("\n            </dd>\n            <dd><a href=\"#\" onclick=\"ff.LoadPage(\'/home/frontpage\'); return false;\">返回首页</a></dd>\n            <dd>");
            EndContext();
            BeginContext(909, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:linkbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "255cc73e54558b391efcfc9d603f2ba751c93f2d8893", async() => {
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.LinkButtonTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper);
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Url = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 23 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Target =  ButtonTargetEnum.newwindow;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("target", __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Target, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\360安全浏览器下载\余氏东风\余氏东风\Views\Home\Header.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.IsLink = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("is-link", __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.IsLink, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.Text = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __WalkingTec_Mvvm_TagHelpers_LayUI_LinkButtonTagHelper.WindowTitle = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1034, 103, true);
            WriteLiteral("</dd>\n        </dl>\n    </li>\n    <li class=\"layui-nav-item\"><a href=\"/Login/Logout\">退出</a></li>\n</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalkingTec.Mvvm.Core.BaseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
