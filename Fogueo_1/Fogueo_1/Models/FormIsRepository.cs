using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fogueo_1.Models
{
    public class FormIsRepository
    {
        public static List<AsignaturesModel> GetAsignatures()
        {
            return new List<AsignaturesModel>
            {
                new AsignaturesModel
                {
                    CodigoAsignatura = "MAT-101",
                    NombreAsignatura = "Cálculo diferencial.",
                    CreditosAsignatura = 5
                },
                new AsignaturesModel
                {
                    CodigoAsignatura = "CBG-120",
                    NombreAsignatura = "Ética 3.",
                    CreditosAsignatura = 3
                },
                new AsignaturesModel
                {
                    CodigoAsignatura = "TDS-005",
                    NombreAsignatura = "Diseño centrado en el usuario.",
                    CreditosAsignatura = 4
                },
                new AsignaturesModel
                {
                    CodigoAsignatura = "TDS-102",
                    NombreAsignatura = "Base de datos avanzada.",
                    CreditosAsignatura = 4
                },
                new AsignaturesModel
                {
                    CodigoAsignatura = "TDS-006",
                    NombreAsignatura = "Programación II.",
                    CreditosAsignatura = 4
                },
                new AsignaturesModel
                {
                    CodigoAsignatura = "ING-110",
                    NombreAsignatura = "Inglés técnico.",
                    CreditosAsignatura = 4
                }
            };
        }
    }
}
