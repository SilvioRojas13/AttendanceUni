using AttendanceUni;

// Variable para elegir el modo de ejecución
bool usarDatosPrecargados = false;

// Usar datos precargados o ingresarlos manualmente
Console.WriteLine("¿Desea usar datos precargados? (S/N): ");
string opcion = Console.ReadLine();

if (opcion == "S")
{
    usarDatosPrecargados = true;
}

List<Universidad.Estudiante> estudiantes;

if (usarDatosPrecargados)
{
    // Datos precargados
    estudiantes = new List<Universidad.Estudiante>
    {
        new Universidad.Estudiante("Juan", 20, 18),
        new Universidad.Estudiante("María", 20, 14),
        new Universidad.Estudiante("Carlos", 20, 10)
    };
}
else
{
    // Ingresar estudiantes manualmente
    estudiantes = IngresarEstudiantesDesdeConsola();
}

// Mostrar la información de cada estudiante
foreach (var estudiante in estudiantes)
{
    estudiante.MostrarInformacion();
}
    

// Método para ingresar estudiantes desde la consola
static List<Universidad.Estudiante> IngresarEstudiantesDesdeConsola()
{
    var estudiantes = new List<Universidad.Estudiante>();

    // Obtener la cantidad de estudiantes a registrar
    int cantidadEstudiantes = ObtenerNumeroValido("Ingrese la cantidad de estudiantes: ");

    for (int i = 0; i < cantidadEstudiantes; i++)
    {
        Console.WriteLine($"\nIngrese los datos del estudiante #{i + 1}:");
        // Pedir el nombre
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        // Pedir el número total de sesiones (con validación)
        int totalSesiones = ObtenerNumeroValido("Total de sesiones: ");

        // Pedir el número de sesiones asistidas (con validación)
        int sesionesAsistidas = ObtenerNumeroValido("Sesiones asistidas: ", totalSesiones);

        // Crear un nuevo estudiante y agregarlo a la lista
        estudiantes.Add(new Universidad.Estudiante(nombre, totalSesiones, sesionesAsistidas));
    }
    return estudiantes;
}

    // Método para obtener un número entero válido desde la consola
static int ObtenerNumeroValido(string mensaje, int? maximoPermitido = null)
{
    int numero;
    bool esValido;

    do
    {
        Console.Write(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out numero);

        if (!esValido || numero <= 0 || (maximoPermitido.HasValue && numero > maximoPermitido.Value))
        {
            esValido = false;
            Console.WriteLine("Valor inválido. Intente nuevamente.");
        }
    } while (!esValido);
    return numero;
}
