List<Tarea> tareas = new List<Tarea>();

// FUNCION MOSTRAR
static void MostrarListaTareas(List<Tarea> tareas)
{
    foreach (var ta in tareas)
    {
        // el cout es una propiedad que devuelve el numero de elementos que tiene una lista
        Console.WriteLine($"Id:{ta._Identificacion}, Nombre:{ta.Nombre}, Descripcion: {ta.Descripcion}, Completado: {ta.Completado}");

    }
}

// FUNCION INSERTAR
static void InsertarListaTareas(List<Tarea> tareas)
{
    int id=0;
    Console.WriteLine("El id se creara automaticamente.");

    Console.WriteLine("Digite el nombre de la tarea");
    string? nomb = Console.ReadLine();

    Console.WriteLine("Digite la descripcion de la tarea");
    string? descrip = Console.ReadLine();

    Console.WriteLine("esta completado si o no?");
    string? compl = Console.ReadLine();


    for (int i = 0; i < tareas.Count; i++)
    {
        id++;
    }
    Tarea tarea1 = new Tarea {_Identificacion=id, Nombre = nomb, Descripcion = descrip, Completado = compl };
    tareas.Add(tarea1);
}

// FUNCION ELIMINAR
static void EliminarListaTareas(List<Tarea> tareas)
{
    Console.WriteLine("Digite el id de la tarea a eliminar");
    int id2 = int.Parse(Console.ReadLine());

    Tarea? eliminar = tareas.FirstOrDefault(t => t._Identificacion == id2);
    if (eliminar != null)
    {
        tareas.Remove(eliminar);
        Console.WriteLine($"\nTarea con Id {id2} eliminada.");
    }
    else
    {
        Console.WriteLine($"\nTarea con Id {id2} no encontrada.");
    }
}

// FUNCION EDITAR
static void EditarCompletado(List<Tarea> tareas)
{
    Console.WriteLine("Digite el id de la tarea a marcar como completada:");
    int id = int.Parse(Console.ReadLine());

    // Buscar la tarea por ID, si no encuentra el valor arroja null
    Tarea? tarea = tareas.FirstOrDefault(t => t._Identificacion == id);

    if (tarea != null)
    {
        string? verdadero="si";
        string? falso="no";
        Console.WriteLine("¿Has completado la tarea? Marcar 'si' o 'no':");
        string? modificar = Console.ReadLine();

        // Validar si el dato que esta ingresando es correcto
        if (modificar != verdadero && modificar != falso)
        {
            Console.WriteLine("Error, digitar lo requerido.");
        }
        else
        {
            // !string.IsNullOrEmpty(modificar) es un metodo para string que se asegura de que el valor "modificar" no este vacio o sea null
            if (!string.IsNullOrEmpty(modificar))
            {
                tarea.Completado = modificar;
                Console.WriteLine($"El estado de la tarea con ID {id} ha sido actualizado a '{modificar}'.");
            }
            else
            {
                Console.WriteLine("El estado no puede estar vacío.");
            }
        }
    }
    else
    {
        Console.WriteLine($"Tarea con ID {id} no encontrada.");
    }
}

while (true)
{
    Console.WriteLine("╔═════════════════════════════════╗");
    Console.WriteLine("║          MENU PRINCIPAL         ║");
    Console.WriteLine("╠═════════════════════════════════╣");
    Console.WriteLine("║    1.Agregar                    ║");
    Console.WriteLine("║    2.Mostrar                    ║");
    Console.WriteLine("║    3.Eliminar                   ║");
    Console.WriteLine("║    4.Tarea completada           ║");
    Console.WriteLine("║    5.Salir                      ║");
    Console.WriteLine("╠═════════════════════════════════╣");
    Console.WriteLine("║     Seleccione una opcion( )    ║");
    Console.WriteLine("╚═════════════════════════════════╝");
    Console.Write("Digite la opcion:");
    int op = int.Parse(Console.ReadLine());

    // VALIDA QUE EL NUMERRO INGRESADO NO SEA DIFERENTE A LOS DEL MENU
    if (op < 1 || op > 5)
    {
        Console.WriteLine("Por favor seguir instrupciones del menu principal.");
    }
    else
    {
        if (op == 1)
        {
            InsertarListaTareas(tareas);
        }
        else if (op == 2)
        {
            MostrarListaTareas(tareas);
        }
        else if (op == 3)
        {
            MostrarListaTareas(tareas);
            EliminarListaTareas(tareas);
        }
        else if (op == 4)
        {
            MostrarListaTareas(tareas);
            EditarCompletado(tareas);
        }

        else if (op == 5)
        {
            Console.WriteLine("Hasta luego.");
            break;
        }
    }
}

// CLASE DE LAS TAREAS
public class Tarea
{
    private int _Identificador { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string? Completado { get; set; }

    public int _Identificacion
    {
        get { return _Identificador; }
        set
        {
            _Identificador = value;
        }
    }
}