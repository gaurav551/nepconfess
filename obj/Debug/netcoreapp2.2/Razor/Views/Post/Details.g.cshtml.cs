#pragma checksum "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184a9c34c1f559460260210cca3bb7f55453dcc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Details), @"mvc.1.0.view", @"/Views/Post/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Details.cshtml", typeof(AspNetCore.Views_Post_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184a9c34c1f559460260210cca3bb7f55453dcc4", @"/Views/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19caef3230ecac71dbd1c302cf624c45712638ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-reply text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
     
    ViewBag.Title = "Post Details";   

#line default
#line hidden
            BeginContext(64, 60, true);
            WriteLiteral("<style>\r\n    img {\r\n    border-radius: 8px;\r\n}\r\n</style>\r\n  ");
            EndContext();
            BeginContext(125, 13, false);
#line 10 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
Write(TempData["c"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 251, true);
            WriteLiteral("\r\n    <section class=\"blog_area p_120 single-post-area\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-8\">\r\n       \t\t\t\t\t<div class=\"main_blog_details\">\r\n       \t\t\t\t\t\t\r\n       \t\t\t\t\t\t<h4>");
            EndContext();
            BeginContext(390, 11, false);
#line 17 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                              Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(401, 115, true);
            WriteLiteral("</h4>\r\n       \t\t\t\t\t\t<div class=\"user_details\">\r\n       \t\t\t\t\t\t\t<div class=\"float-left\">\r\n       \t\t\t\t\t\t\t\t<a href=\"#\">");
            EndContext();
            BeginContext(517, 14, false);
#line 20 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                              Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(531, 185, true);
            WriteLiteral("</a>\r\n       \t\t\t\t\t\t\t\t\r\n       \t\t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t\t<div class=\"float-right\">\r\n       \t\t\t\t\t\t\t\t<div class=\"media\">\r\n       \t\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n       \t\t\t\t\t\t\t\t\t\t<h5>");
            EndContext();
            BeginContext(717, 12, false);
#line 26 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                              Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(729, 27, true);
            WriteLiteral("</h5>\r\n       \t\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(757, 10, false);
#line 27 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                             Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(767, 89, true);
            WriteLiteral("</p>\r\n       \t\t\t\t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t\t\t\t<div class=\"d-flex\">\r\n       \t\t\t\t\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 856, "\"", 890, 2);
            WriteAttributeValue("", 862, "/userimages/", 862, 12, true);
#line 30 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
WriteAttributeValue("", 874, ViewBag.userpic, 874, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(891, 144, true);
            WriteLiteral(" height=\"40px\" width=\"40px\" alt=\"\">\r\n       \t\t\t\t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t</div>\r\n       \t\t\t\t\t\t<p> ");
            EndContext();
            BeginContext(1036, 27, false);
#line 35 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                              Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 60, true);
            WriteLiteral("</p>\r\n      \t\t\t\t\t\t<div class=\"news_d_footer\">\r\n      \t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1123, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "184a9c34c1f559460260210cca3bb7f55453dcc49068", async() => {
                BeginContext(1191, 31, true);
                WriteLiteral(" <i class=\"fa fa-heart\" ></i>  ");
                EndContext();
                BeginContext(1223, 13, false);
#line 37 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                                                                                Write(ViewBag.likes);

#line default
#line hidden
                EndContext();
                BeginContext(1236, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1241, 130, true);
            WriteLiteral("\r\n                                 \r\n      \t\t\t\t\t\t\t<a class=\"justify-content-center ml-auto\" href=\"#\"><i class=\"fa fa-comment\"></i>");
            EndContext();
            BeginContext(1372, 22, false);
#line 39 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                                                             Write(ViewBag.comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 37, true);
            WriteLiteral(" Comments <i class=\"fa fa-eye\"> </i> ");
            EndContext();
            BeginContext(1432, 17, false);
#line 39 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                                                                                                                         Write(ViewBag.postcount);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 352, true);
            WriteLiteral(@" views</a> 
      							<div class=""news_socail ml-auto"">
									<a ><i class=""fa fa-user""></i></a>
									<a ><i class=""fa fa-tv""></i></a>
                                   
									
								</div>
      						</div>
       					</div>
       					
                        <div class=""comments-area"">
                            <h4>");
            EndContext();
            BeginContext(1802, 22, false);
#line 50 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                           Write(ViewBag.comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 16, true);
            WriteLiteral(" Comments</h4>\r\n");
            EndContext();
#line 51 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                             foreach (var x in ViewBag.comments)
                            {

#line default
#line hidden
            BeginContext(1937, 397, true);
            WriteLiteral(@"                            <div class=""comment-list"">
                                <div class=""single-comment justify-content-between d-flex"">
                                    <div class=""user justify-content-between d-flex"">
                                       
                                        <div class=""desc"">
                                            <h5><a href=""#"">");
            EndContext();
            BeginContext(2335, 25, false);
#line 58 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                       Write(x.CommentBy.Split('@')[0]);

#line default
#line hidden
            EndContext();
            BeginContext(2360, 71, true);
            WriteLiteral("</a></h5>\r\n                                            <p class=\"date\">");
            EndContext();
            BeginContext(2432, 6, false);
#line 59 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                       Write(x.DaTe);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 120, true);
            WriteLiteral(" </p>\r\n                                            <p class=\"comment\">\r\n                                                ");
            EndContext();
            BeginContext(2559, 13, false);
#line 61 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                           Write(x.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(2572, 248, true);
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"reply-btn\">\r\n                                           ");
            EndContext();
            BeginContext(2820, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "184a9c34c1f559460260210cca3bb7f55453dcc416116", async() => {
                BeginContext(2926, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                                                 WriteLiteral(x.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2936, 222, true);
            WriteLiteral(" \r\n                                           <a href=\"\" class=\"btn-reply text-uppercase\">Edit</a> \r\n                                    </div>\r\n                                </div>\r\n                            </div>\t\r\n");
            EndContext();
#line 71 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(3189, 303, true);
            WriteLiteral(@"                           	
                            	
                                                                        				
                        </div>
                        <div class=""comment-form"">
                            <h4>Leave a Reply</h4>
                            ");
            EndContext();
            BeginContext(3492, 612, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "184a9c34c1f559460260210cca3bb7f55453dcc419549", async() => {
                BeginContext(3558, 79, true);
                WriteLiteral("\r\n                               <input type=\"hidden\" name=\"postId\" id=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3637, "\"", 3654, 1);
#line 79 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
WriteAttributeValue("", 3645, Model.Id, 3645, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3655, 442, true);
                WriteLiteral(@"/>
                              
                                <div class=""form-group"">
                                    <textarea class=""form-control mb-10"" rows=""5"" name=""commenttext"" placeholder=""Reply"" ></textarea>
                                   
                                </div>
                                <input type=""submit"" value="" Comment"" class=""primary-btn submit_btn""/>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4104, 944, true);
            WriteLiteral(@"
                        </div>
        			</div>
                    <div class=""col-lg-4"">
                        <div class=""blog_right_sidebar"">
                            <aside class=""single_sidebar_widget search_widget"">
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control"" placeholder=""Search Posts"">
                                    <span class=""input-group-btn"">
                                        <button class=""btn btn-default"" type=""button""><i class=""lnr lnr-magnifier""></i></button>
                                    </span>
                                </div><!-- /input-group -->
                                <div class=""br""></div>
                            </aside>
                            <aside class=""single_sidebar_widget author_widget"">
                                <img class=""author_img img-fluid""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5048, "\"", 5082, 2);
            WriteAttributeValue("", 5054, "/userimages/", 5054, 12, true);
#line 101 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
WriteAttributeValue("", 5066, ViewBag.userpic, 5066, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5083, 62, true);
            WriteLiteral("  height=\"100px\" alt=\"\">\r\n                                <h4>");
            EndContext();
            BeginContext(5146, 19, false);
#line 102 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                               Write(ViewBag.displayname);

#line default
#line hidden
            EndContext();
            BeginContext(5165, 521, true);
            WriteLiteral(@"</h4>
                                <p>Senior blog writer</p>
                                <div class=""social_icon"">
                                    <a href=""#""><i class=""fa fa-clock""></i></a>
                                    <a href=""#""><i class=""fa fa-heart""></i></a>
                                    <a href=""#""><i class=""fa fa-car""></i></a>
                                    <a href=""#""><i class=""fa fa-user""></i></a>
                                </div>
                                <p>");
            EndContext();
            BeginContext(5687, 11, false);
#line 110 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                              Write(ViewBag.bio);

#line default
#line hidden
            EndContext();
            BeginContext(5698, 100, true);
            WriteLiteral("</p>\r\n                                <div class=\"br\"></div>\r\n                            </aside>\r\n");
            EndContext();
#line 113 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                            if(ViewBag.postbyauthor!=null)
                           {

#line default
#line hidden
            BeginContext(5888, 161, true);
            WriteLiteral("                            <aside class=\"single_sidebar_widget popular_post_widget\">\r\n                                <h3 class=\"widget_title\">Popular Posts By ");
            EndContext();
            BeginContext(6050, 19, false);
#line 116 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                     Write(ViewBag.displayname);

#line default
#line hidden
            EndContext();
            BeginContext(6069, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 117 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                 foreach(var x in ViewBag.postbyauthor)
                                    {

#line default
#line hidden
            BeginContext(6188, 195, true);
            WriteLiteral("                                <div class=\"media post_item\">\r\n                                  <div class=\"media-body\">\r\n                                        <a href=\"blog-details.html\"><h3>");
            EndContext();
            BeginContext(6384, 7, false);
#line 121 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                                                   Write(x.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6391, 54, true);
            WriteLiteral("</h3></a>\r\n                                        <p>");
            EndContext();
            BeginContext(6446, 6, false);
#line 122 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                      Write(x.Date);

#line default
#line hidden
            EndContext();
            BeginContext(6452, 90, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 125 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6581, 194, true);
            WriteLiteral("                              \r\n                                \r\n                                \r\n                                <div class=\"br\"></div>\r\n                            </aside>\r\n");
            EndContext();
#line 131 "C:\Users\Lenovo\Desktop\NepConfess\Views\Post\Details.cshtml"
                           }

#line default
#line hidden
            BeginContext(6805, 191, true);
            WriteLiteral("                           \r\n                                                   </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n\r\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591