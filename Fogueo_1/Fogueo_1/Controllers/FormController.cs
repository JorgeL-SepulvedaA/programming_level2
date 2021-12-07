using Fogueo_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Fogueo_1.Controllers
{
    public class FormController : Controller
    {
        public IWebHostEnvironment MapPath;
        public FormController(IWebHostEnvironment mapPath)
        {
            MapPath = mapPath;
        }
        public IActionResult Index(IFormFile foto)
        {
            string nombre = Path.GetFileName(foto.FileName);
            string ruta = Path.Combine(MapPath.WebRootPath + "/Fotos", nombre);

            Stream stream = foto.OpenReadStream();
            foto.CopyTo(stream);

            string pasatiempo = "| ";
            if (Request.Form["ver"] == "ver series/peliculas")
            {
                pasatiempo += Request.Form["ver"] + " |";
            }
            else if (Request.Form["escuchar"] == "escuchar/escribir música")
            {
                pasatiempo += Request.Form["escuchar"] + " |";
            }
            else if (Request.Form["leer"] == "leer/escribir libros")
            {
                pasatiempo += Request.Form["ver"] + " |";
            }
            else if (Request.Form["documental"] == "observar documentales/materiales didacticos")
            {
                pasatiempo += Request.Form["ver"] + " |";
            }
            else
            {
                pasatiempo += "no seleccionado |";
            }

            FormIsModel datos = new FormIsModel
            {
                Cedula = Request.Form["cedula"],
                Nombre = Request.Form["nombre"],
                Apellido = Request.Form["apellido"],
                Edad = int.Parse(Request.Form["edad"]),
                Telefono = Request.Form["telefono"],
                Email = Request.Form["email"],
                Genero = Request.Form["genero"],
                EstadoCivil = Request.Form["estado_civil"],
                Hobbies = pasatiempo,
                Foto = ruta
            };

            return View(datos);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
