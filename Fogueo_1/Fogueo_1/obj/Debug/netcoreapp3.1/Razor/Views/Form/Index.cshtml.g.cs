#pragma checksum "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a8eb4caf0cb22db957c9a96e294270f0574489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Index), @"mvc.1.0.view", @"/Views/Form/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a8eb4caf0cb22db957c9a96e294270f0574489", @"/Views/Form/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f184ba1dbc052576cd6df10b07bedaf35e5d0ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fogueo_1.Models.FormIsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
  
    ViewBag.Tittle = ">DATOS INGRESADOS<";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"encabezado\" class=\"bg-white\">\r\n    <h1 class=\"text-center text-white\">\r\n        ");
#nullable restore
#line 10 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
   Write(ViewBag.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <fieldset id=\"encabezado1\" class=\"text-justify text-dark\">\r\n        <label>Cédula: ");
#nullable restore
#line 13 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                  Write(Model.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Nombre: ");
#nullable restore
#line 15 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                  Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Apellido: ");
#nullable restore
#line 17 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                    Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Edad: ");
#nullable restore
#line 19 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Teléfono: ");
#nullable restore
#line 21 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                    Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Correo electrónico: ");
#nullable restore
#line 23 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Género: ");
#nullable restore
#line 25 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                  Write(Model.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Estado civil: ");
#nullable restore
#line 27 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                        Write(Model.EstadoCivil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Hobbies: ");
#nullable restore
#line 29 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
                   Write(Model.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <br />\r\n        <label>Foto: </label>\r\n        <br />\r\n        <img");
            BeginWriteAttribute("src", " src=", 1037, "", 1053, 1);
#nullable restore
#line 33 "C:\Users\jorge\OneDrive - República Digital Educación\1 - UNIVERSIDAD\C3-2021\Programación II (TDS-006)\Programas\Fogueo_1\Fogueo_1\Views\Form\Index.cshtml"
WriteAttributeValue("", 1042, Model.Foto, 1042, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" sizes=\"20%\">\r\n    </fieldset>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fogueo_1.Models.FormIsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591