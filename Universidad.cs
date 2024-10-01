using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceUni
{
    public class Universidad
    {
        // Añadir clase anidada de estudiante
        public class Estudiante
        {
            // Propiedades de cada estudiante
            public string Nombre { get; set; }
            public int TotalSesiones { get; set; }
            public int SesionesAsistidas { get; set; }

            // Constructor para inicializar al estudiante
            public Estudiante(string nombre, int totalSesiones, int sesionesAsistidas)
            {
                Nombre = nombre;
                TotalSesiones = totalSesiones;
                SesionesAsistidas = sesionesAsistidas;
            }
        }
    }
}
