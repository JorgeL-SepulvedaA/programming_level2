using StudentsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Students datos = new Students
            {
                Matricula = Request.Form["matricula"],
                Nombre = Request.Form["nombre"],
                Apellido = Request.Form["apellido"],
                FechaNacimiento = DateTime.Parse(Request.Form["fecha_nacimiento"]),
                Carrera = Request.Form["carrera"],
                Direccion = Request.Form["direccion"],
                Telefono = Request.Form["telefono"],
                Email = Request.Form["email"]
            };

            return View(datos);
        }

        /*public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}