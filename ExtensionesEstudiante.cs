using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceUni
{
    public static class ExtensionesEstudiante
    {
        // Método de extensión para mostrar la información del estudiante
        public static void MostrarInformacion(this Universidad.Estudiante estudiante)
        {
            double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.TotalSesiones);
            bool cumple = Universidad.Estudiante.Asistencia.CumpleAsistencia(porcentaje);

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Asistencia: {porcentaje:F2}%");
            Console.WriteLine($"Estado: {(cumple ? "Aprobado" : "No aprobado")}");
            Console.WriteLine();
        }
    }
}
