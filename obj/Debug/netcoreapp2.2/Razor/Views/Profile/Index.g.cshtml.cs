#pragma checksum "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d75418c79fab42983e116718c0d6512550ddaea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Index.cshtml", typeof(AspNetCore.Views_Profile_Index))]
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
#line 1 "C:\Users\Lenovo\Desktop\NepConfess\Views\_ViewImports.cshtml"
using NepConfess;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\NepConfess\Views\_ViewImports.cshtml"
using NepConfess.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d75418c79fab42983e116718c0d6512550ddaea", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19caef3230ecac71dbd1c302cf624c45712638ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("\r\n\r\n<style>\r\n  img {\r\n    border-radius: 18px;\r\n}\r\n</style>\r\n");
            EndContext();
            BeginContext(77, 14, true);
            WriteLiteral("\r\n<br>\r\n<br>\r\n");
            EndContext();
#line 12 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
 if(Model == null)
{
 
     

#line default
#line hidden
            BeginContext(124, 100, true);
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n  Why Havent You created a profile yet? <span> Click ");
            EndContext();
            BeginContext(224, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d75418c79fab42983e116718c0d6512550ddaea4270", async() => {
                BeginContext(269, 3, true);
                WriteLiteral("Me ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 39, true);
            WriteLiteral(" To Create A new One </span>!\r\n</div>\r\n");
            EndContext();
#line 19 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
}
else
{
    {
    ViewData["Profile"] = @Model.DisplayName;
}

#line default
#line hidden
            BeginContext(384, 257, true);
            WriteLiteral(@" <div class=""cover--header pt--80 text-center""  data-overlay=""0.6"" data-overlay-color=""white"">
            <div class=""container"">
                <div class=""cover--avatar online"" data-overlay=""0.3"" data-overlay-color=""primary"">
                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 641, "\"", 674, 2);
            WriteAttributeValue("", 647, "/userimages/", 647, 12, true);
#line 28 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
WriteAttributeValue("", 659, Model.ImageUrl, 659, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(675, 156, true);
            WriteLiteral(" height=\"100px\" width=\"100px\" alt=\"\">\r\n                </div>\r\n\r\n                <div class=\"cover--user-name\">\r\n                    <h2 class=\"h3 fw--600\">");
            EndContext();
            BeginContext(832, 17, false);
#line 32 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                      Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(849, 155, true);
            WriteLiteral("</h2>\r\n                </div>\r\n\r\n                <div class=\"cover--user-activity\">\r\n                    <p><i class=\"fa fa-clock\"></i>Active member since ");
            EndContext();
            BeginContext(1005, 36, false);
#line 36 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                                 Write(Model.Date.ToString("dd, MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 141, true);
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"cover--user-desc fw--400 fs--18 fstyle--i text-darkest\">\r\n                    <p>");
            EndContext();
            BeginContext(1183, 9, false);
#line 40 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                  Write(Model.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 101, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Cover Header End -->\r\n");
            EndContext();
            BeginContext(1295, 1409, true);
            WriteLiteral(@"        <!-- Page Wrapper Start -->
        <section class=""page--wrapper pt--80 pb--20"">
            <div class=""container"">
                <div class=""row"">
                    <!-- Main Content Start -->
                    <div class=""main--content col-md-8 pb--60"" >
                        <div class=""main--content-inner drop--shadow"">
                          
                            <!-- Profile Details Start -->
                            <div class=""profile--details fs--14"">
                                <!-- Profile Item Start -->
                                <div class=""profile--item"">
                                    <div class=""profile--heading"">
                                        <h3 class=""h4 fw--700"">
                                            <span class=""mr--4"">About Me</span>
                                            <i class=""ml--10 text-primary fa fa-caret-right""></i>
                                        </h3>
                                    ");
            WriteLiteral(@"</div>

                                    <div class=""profile--info"">
                                        <table class=""table"">
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Full Name</th>
                                                <td><a href=""member-profile.html#"" class=""btn-link"">");
            EndContext();
            BeginContext(2705, 17, false);
#line 69 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                                                               Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2722, 257, true);
            WriteLiteral(@"</a></td>
                                            </tr>
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Skill</th>
                                                <td>");
            EndContext();
            BeginContext(2980, 11, false);
#line 73 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                               Write(Model.Skill);

#line default
#line hidden
            EndContext();
            BeginContext(2991, 261, true);
            WriteLiteral(@"</td>
                                            </tr>
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Date of Birth</th>
                                                <td>");
            EndContext();
            BeginContext(3253, 17, false);
#line 77 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                               Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(3270, 933, true);
            WriteLiteral(@"</td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                                <!-- Profile Item End -->

                                <!-- Profile Item Start -->
                                <div class=""profile--item"">
                                    <div class=""profile--heading"">
                                        <h3 class=""h4 fw--700"">
                                            <span class=""mr--4"">Biography</span>
                                            <i class=""ml--10 text-primary fa fa-caret-right""></i>
                                        </h3>
                                    </div>

                                    <div class=""profile--info"">
                                        <p>Hello ! I’m <a href=""member-profile.html#"">");
            EndContext();
            BeginContext(4204, 17, false);
#line 94 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                                                 Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(4221, 6, true);
            WriteLiteral("</a>. ");
            EndContext();
            BeginContext(4228, 9, false);
#line 94 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                                                                         Write(Model.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(4237, 3921, true);
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <!-- Profile Item End -->

                                <!-- Profile Item Start -->
                                <div class=""profile--item"">
                                    <div class=""profile--heading"">
                                        <h3 class=""h4 fw--700"">
                                            <span class=""mr--4"">Work Experience</span>
                                            <i class=""ml--10 text-primary fa fa-caret-right""></i>
                                        </h3>
                                    </div>

                                    <div class=""profile--info"">
                                        <dl>
                                            <dt>
                                                <p class=""h6 fw--700 text-darkest"">Graphic Designer 2010 - 2012</p>
                                                <p><small cl");
            WriteLiteral(@"ass=""fw--400 fs--12 text-darker"">Graphicriver.net at Sydney</small></p>
                                            </dt>
                                            <dd>
                                                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour which don't look even slightly believable.</p>
                                            </dd>

                                            <dt>
                                                <p class=""h6 fw--700 text-darkest"">Font-End Developer 2012 - 2014</p>
                                                <p><small class=""fw--400 fs--12 text-darker"">Themeforest.net at Australia</small></p>
                                            </dt>
                                            <dd>
                                                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alterati");
            WriteLiteral(@"on in some form, by injected humour which don't look even slightly believable.</p>
                                            </dd>

                                            <dt>
                                                <p class=""h6 fw--700 text-darkest"">Web Developer 2014 - Still Now</p>
                                                <p><small class=""fw--400 fs--12 text-darker"">Codecanyon.net at Sydney</small></p>
                                            </dt>
                                            <dd>
                                                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour which don't look even slightly believable.</p>
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <!-- Profile Item End -->

     ");
            WriteLiteral(@"                           <!-- Profile Item Start -->
                                <div class=""profile--item"">
                                    <div class=""profile--heading"">
                                        <h3 class=""h4 fw--700"">
                                            <span class=""mr--4"">Contact</span>
                                            <i class=""ml--10 text-primary fa fa-caret-right""></i>
                                        </h3>
                                    </div>

                                    <div class=""profile--info"">
                                        <table class=""table"">
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Phone</th>
                                                <td><a >");
            EndContext();
            BeginContext(8159, 11, false);
#line 151 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                   Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(8170, 290, true);
            WriteLiteral(@"</a></td>
                                            </tr>
                                            <tr>
                                                <th class=""fw--700 text-darkest"">E-mail</th>
                                                <td><a ><span class=""__cf_email__"" >");
            EndContext();
            BeginContext(8461, 11, false);
#line 155 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                                               Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(8472, 271, true);
            WriteLiteral(@"</span></a></td>
                                            </tr>
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Website</th>
                                                <td><a \>");
            EndContext();
            BeginContext(8744, 13, false);
#line 159 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                                    Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(8757, 259, true);
            WriteLiteral(@"</a></td>
                                            </tr>
                                            <tr>
                                                <th class=""fw--700 text-darkest"">Address</th>
                                                <td>");
            EndContext();
            BeginContext(9017, 13, false);
#line 163 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
                                               Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(9030, 1152, true);
            WriteLiteral(@"</td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                                <!-- Profile Item End -->
                            </div>
                            <!-- Profile Details End -->
                        </div>
                        
                    </div>
                    <div class=""main--sidebar col-md-4 pb--60"" >
                    <div class=""widget"">
                            <h2 class=""h4 fw--700 widget--title"">Notice</h2>

                            <!-- Text Widget Start -->
                            <div class=""text--widget"">
                                <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some  look even slightly believable.</p>
                            </div>
                            <!-- Text Widget End -->
                 ");
            WriteLiteral("       </div>\r\n                    </div>\r\n                   \r\n                </div>\r\n            </div>\r\n        </section>\r\n");
            EndContext();
#line 189 "C:\Users\Lenovo\Desktop\NepConfess\Views\Profile\Index.cshtml"
        
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
