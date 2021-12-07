using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsForm.Models
{
    public class Students
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; } = new DateTime();
        public string Carrera { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}