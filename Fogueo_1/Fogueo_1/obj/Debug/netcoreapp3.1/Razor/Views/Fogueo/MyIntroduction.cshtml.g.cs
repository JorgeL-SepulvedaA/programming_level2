#pragma checksum "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbad7b89a1eab93503f0621eae8107b787b01015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fogueo_MyIntroduction), @"mvc.1.0.view", @"/Views/Fogueo/MyIntroduction.cshtml")]
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
#line 1 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\_ViewImports.cshtml"
using Fogueo_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\_ViewImports.cshtml"
using Fogueo_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbad7b89a1eab93503f0621eae8107b787b01015", @"/Views/Fogueo/MyIntroduction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f184ba1dbc052576cd6df10b07bedaf35e5d0ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Fogueo_MyIntroduction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
  
    ViewBag.Tittle = "【﻿•　Ｆｏｇｕｅｏ　ｃｏｄｅ　•】";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"encabezado\" class=\"bg-white\">\r\n    <h1 class=\"text-center text-white\">\r\n        ");
#nullable restore
#line 9 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
   Write(ViewBag.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <fieldset id=\"encabezado1\">\r\n        <h2 class=\"text-center\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 374, "", 393, 1);
#nullable restore
#line 13 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
WriteAttributeValue("", 379, ViewBag.Image, 379, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" sizes=\"20%\">\r\n            ");
#nullable restore
#line 14 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
       Write(ViewData["Nombre"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
                           Write(ViewData["Apellido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <h4 class=\"text-center\">\r\n            FECHA NACIMIENTO: ");
#nullable restore
#line 17 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
                         Write(ViewData["FechaNacimento"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            CARRERA: ");
#nullable restore
#line 18 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
                Write(ViewBag.Career);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            MATRÍCULA: ");
#nullable restore
#line 19 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
                  Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            GRUPO: ");
#nullable restore
#line 20 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
              Write(ViewBag.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            CORREO: ");
#nullable restore
#line 21 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
               Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            NÚMERO MÁGICO: ");
#nullable restore
#line 22 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Fogueo\MyIntroduction.cshtml"
                      Write(ViewData["NúmeroMágico"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h4>\r\n    </fieldset>\r\n</div>");
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
