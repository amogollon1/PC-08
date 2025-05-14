using System.Globalization;

class Program
{
    static void Main()
    {
        string[] alumnos = new string[10];
        int[,] notas = new int[10, 10];
        int[] promedio = new int[10];
        double prom = 0;
        //Se instancia el método NombreNotas de la clase Alumno 
        Alumno.NombreNotas(alumnos, notas);
        string opcion = "";
        do
        {
            Console.WriteLine("Menú de opciones.");
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1 - Mostrar nombre y notas aprobadas para cada alumno.");
            Console.WriteLine("2 - Mostrar nombre y notas no aprobadas para cada alumno.");
            Console.WriteLine("3 - Mostrar el promedio de notas del grupo.");
            Console.WriteLine("4 - Salir del programa.");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Menu.MostrarNotasAprobadas(alumnos, notas);
                    break;
                case "2":
                    Menu.MostrarNotasNoAprobadas(alumnos, notas);
                    break;
                case "3":
                    Menu.MostrarPromedio(notas);
                    break;
                case "4":
                    Console.WriteLine("Cerrando programa...");
                    break;
                default:
                    Console.WriteLine("Seleccione una opción válida.");
                    break;
            }
        } while (opcion != "4");
    }
}
