#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0f6ef78026393c755a2596d4ed86eed124f21b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneFestival), @"mvc.1.0.view", @"/Views/Home/OneFestival.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\_ViewImports.cshtml"
using WADWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\_ViewImports.cshtml"
using WADWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0f6ef78026393c755a2596d4ed86eed124f21b", @"/Views/Home/OneFestival.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9ac05d04a36529431cc129f498d4988729f231", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneFestival : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FestivalDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
  
    //@Model WADWebsite.Models.Festival
    ViewData["Title"] = Model.FestivalName;



#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .body{ \r\n        background-color:none;\r\n    }\r\n    .festContainer {\r\n        background-image: url(\"/images/");
#nullable restore
#line 13 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                                  Write(Model.FestivalImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        background-size: 300px 300px;\r\n        background-repeat: repeat\r\n    }\r\n\r\n</style>\r\n\r\n<div class=\"festContainer\">\r\n    <div class=\"festivalInfo\">\r\n        <h1>Festival Details</h1>\r\n        <div class=\"festName\"><h2>");
#nullable restore
#line 23 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                             Write(Model.FestivalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n        <div class=\"festTickType\"><h3>");
#nullable restore
#line 24 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                                 Write(Model.TicketType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n");
#nullable restore
#line 25 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
         if (Model.CampingIncluded == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><h3>Camping included</h3></div>\r\n");
#nullable restore
#line 28 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><h3>Camping not included</h3></div>\r\n");
#nullable restore
#line 32 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"festPrice\"><h3>??");
#nullable restore
#line 33 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                               Write(Model.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n");
#nullable restore
#line 34 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
         if (@Model.TicketType.Contains("Day"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"festDate\"><h3>");
#nullable restore
#line 36 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                                 Write(Model.StartDate.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n");
#nullable restore
#line 37 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"festDate\"><h3>");
#nullable restore
#line 40 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                                 Write(Model.StartDate.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 40 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                                                                          Write(Model.EndDate.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n");
#nullable restore
#line 41 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
         switch (Model.FestivalName)
        {
            case "Nass":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://www.nassfestival.com/lineup/\';\">Line Up</button></div>\r\n");
#nullable restore
#line 47 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Parklife":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://parklife.uk.com/#lineup\';\">Line Up</button></div>\r\n");
#nullable restore
#line 51 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Boomtown":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><h5>Lineup not released</h5></div>\r\n");
#nullable restore
#line 55 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Bassfest":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div><button class=""glow-on-hover"" onclick=""window.location = 'https://www.electronic-festivals.com/event/bassfest-summer-festival#:~:text=The%20current%20lineup%20is%20not%20out%20yet.%20These,Boy%2C%20Swifta%20Beater%2C%20Notion%2C%20Ts7%2C%20Hedex%2C%20Splash%2C%20Conducta';"">Line Up</button></div>
");
#nullable restore
#line 59 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Leedsfest":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://www.leedsfestival.com/lineup#poster\';\">Line Up</button></div>\r\n");
#nullable restore
#line 63 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Reading fest":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://www.readingfestival.com/lineup#poster\';\">Line Up</button></div>\r\n");
#nullable restore
#line 67 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Neighbourhood weekender":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://nbhdweekender.com/\';\">Line Up</button></div>\r\n");
#nullable restore
#line 71 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Creamfields":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><button class=\"glow-on-hover\" onclick=\"window.location = \'https://creamfields.com/lineup\';\">Line Up</button></div>\r\n");
#nullable restore
#line 75 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Shindig":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><h5>Lineup not released</h5></div>\r\n");
#nullable restore
#line 79 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

            case "Blue dot":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><h5>Lineup not released</h5></div>\r\n");
#nullable restore
#line 83 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
                break;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0f6ef78026393c755a2596d4ed86eed124f21b12965", async() => {
                WriteLiteral("\r\n\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3268, "\"", 3293, 1);
#nullable restore
#line 89 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
WriteAttributeValue("", 3276, Model.FestivalID, 3276, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FestivalID\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3349, "\"", 3376, 1);
#nullable restore
#line 90 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
WriteAttributeValue("", 3357, Model.FestivalName, 3357, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FestivalName\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3434, "\"", 3459, 1);
#nullable restore
#line 91 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
WriteAttributeValue("", 3442, Model.TicketType, 3442, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"TicketType\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3515, "\"", 3541, 1);
#nullable restore
#line 92 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
WriteAttributeValue("", 3523, Model.TicketPrice, 3523, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"TicketPrice\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3598, "\"", 3626, 1);
#nullable restore
#line 93 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
WriteAttributeValue("", 3606, Model.FestivalImage, 3606, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FestivalImage\" />\r\n            <button type=\"submit\" class=\"glow-on-hover\">Add to Cart</button>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
#nullable restore
#line 100 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
     switch (Model.FestivalName)
    {
        case "Nass":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d637430.0020997052!2d-2.4649563991512337!3d51.385395821308315!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487224f11d035043%3A0xf288464399cdb6ee!2sThe%20Royal%20Bath%20%26%20West%20Showground!5e0!3m2!1sen!2snl!4v1623855954559!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4217, "\"", 4235, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 104 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Parklife":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d37947.273138415665!2d-2.281086943605166!3d53.52733287316332!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x83141b7c1fabbb4d!2sParklife%20Manchester!5e0!3m2!1sen!2snl!4v1623856356100!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4660, "\"", 4678, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 108 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Boomtown":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d320507.56805667525!2d-1.3011661441605622!3d51.127546694510386!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487413f62ef08e79%3A0x2c35a5c6c0eeb003!2sBoomtown%20Fair!5e0!3m2!1sen!2snl!4v1623856412154!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 5114, "\"", 5132, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 112 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Bassfest":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9515.156607383038!2d-1.432573494178446!3d53.400711518816884!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487977a40def6bcb%3A0xafec53ee7b27e229!2sDon%20Valley%20Bowl!5e0!3m2!1sen!2snl!4v1623856461127!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 5570, "\"", 5588, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 116 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Leedsfest":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d75313.4222629488!2d-1.4137304876702574!3d53.85096599639972!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x8cc467707b2fe52f!2sBramham%20Park!5e0!3m2!1sen!2snl!4v1623856587932!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6006, "\"", 6024, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 120 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Reading fest":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9943.074434791015!2d-1.0002752423139875!3d51.46240470275564!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48769bac1a0a80f5%3A0x6840f8c838af189e!2sDrayton%20D%20A!5e0!3m2!1sen!2snl!4v1623856969720!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6462, "\"", 6480, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 124 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Neighbourhood weekender":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1189.883243455457!2d-2.5762377737824144!3d53.38322749497217!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487b021f9f9565a9%3A0xd93ee661aab20b7b!2sVictoria%20Park%2C%20Warrington%2C%20UK!5e0!3m2!1sen!2snl!4v1623857200848!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6953, "\"", 6971, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 128 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Creamfields":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2381.8065973536886!2d-2.628691548156107!3d53.34671817988085!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487afd9dd31799cd%3A0xe663de86de4a1848!2sCreamfields%20Festival!5e0!3m2!1sen!2snl!4v1623857252230!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 7415, "\"", 7433, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 132 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Shindig":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d321188.92535434564!2d-3.2385553330707135!3d51.02929246772571!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487273ae9eb4ce4f%3A0xce4bd029d77d80f9!2sShindig%20Festival!5e0!3m2!1sen!2snl!4v1623857305176!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 7870, "\"", 7888, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 136 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

        case "Blue dot":

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <iframe class=""festivalMap"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d152769.08711288692!2d-2.434509159089362!3d53.25339564869691!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487a50fc0f5723ed%3A0xa1d78d08f23bd37c!2sJodrell%20Bank%20Discovery%20Centre!5e0!3m2!1sen!2snl!4v1623857407415!5m2!1sen!2snl"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 8342, "\"", 8360, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
#nullable restore
#line 140 "C:\Users\LabStudent-55-504266\source\repos\WADWebsite\WADWebsite\Views\Home\OneFestival.cshtml"
            break;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
