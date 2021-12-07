using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class Vacation
    {
        public string Cedula { get; set; }
        public DateTime FechaInicio { get; set; } = new DateTime();
        public DateTime FechaFin { get; set; } = new DateTime();
        public TimeSpan FechaCompleta { get; set; } = new TimeSpan();
    }
}
