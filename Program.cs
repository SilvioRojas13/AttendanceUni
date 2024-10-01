using AttendanceUni;

var estudiantes = new List<Universidad.Estudiante>
{
    new Universidad.Estudiante("Juan", 20, 18),
    new Universidad.Estudiante("María", 20, 14),
    new Universidad.Estudiante("Carlos", 20, 10)
};
            

// Mostrar la información de cada estudiante
foreach (var estudiante in estudiantes)
{
    estudiante.MostrarInformacion();
}