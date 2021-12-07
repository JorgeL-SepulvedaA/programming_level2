using Fogueo_1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fogueo_1.Controllers
{
    public class FogueoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PilaresPOO()
        {
            return View();
        }
        public IActionResult ASPNET()
        {
            return View();
        }
        public IActionResult MyIntroduction()
        {
            ViewBag.Id = "2020-10714";
            ViewBag.Group = "G-4";
            ViewBag.Career = "Desarrollo de Software";
            ViewData["Nombre"] = "Jorge Luis";
            ViewData["Apellido"] = "Sepúlveda Abreu";
            ViewData["FechaNacimento"] = new DateTime(2000, 10, 09);
            ViewBag.Email = "202010714@itla.edu.do";
            ViewData["NúmeroMágico"] = 2 * Math.Pow(20, 3);
            ViewBag.Image = "https://cvjlsa.000webhostapp.com/JORGE.jpg";

            return View();
        }
        public IActionResult ViewAsignatures()
        {
            var asignaturesModel = from x in AsignaturesRepository.GetAsignatures()
                                   orderby x.CodigoAsignatura
                                   select x;
            return View(asignaturesModel);
        }
        public IWebHostEnvironment MapPath;
        public FogueoController(IWebHostEnvironment mapPath)
        {
            MapPath = mapPath;
        }
        public IActionResult Formulario(IFormFile foto)
        {
            string nombre = Path.GetFileName(foto.FileName);
            string ruta = Path.Combine(MapPath.WebRootPath + "/Fotos", nombre);

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