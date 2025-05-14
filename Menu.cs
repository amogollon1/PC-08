class Menu
{
    public static void MostrarNotasAprobadas(string[] alumnos, int[,] notas)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nNotas aprobadas para {alumnos[i]}:");
            bool aprobada = false;
            for (int j = 0; j < 10; j++)
            {
                if (notas[i, j] >= 65)
                {
                    Console.WriteLine($"  Nota {j + 1}: {notas[i, j]}");
                    aprobada = true;
                }
            }
            if (!aprobada)
            {
                Console.WriteLine("  No tiene notas aprobadas.");
            }
        }
    }

    public static void MostrarNotasNoAprobadas(string[] alumnos, int[,] notas)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nNotas reprobadas para {alumnos[i]}:");
            bool reprobada = false;
            for (int j = 0; j < 10; j++)
            {
                if (notas[i, j] < 65)
                {
                    Console.WriteLine($"  Nota {j + 1}: {notas[i, j]}");
                    reprobada = true;
                }
            }
            if (!reprobada)
            {
                Console.WriteLine("  No tiene notas reprobadas.");
            }
        }
    }
    public static void MostrarPromedio(int[,] notas)
    {
        double sumaTotal = 0;
        int totalNotas = notas.GetLength(0) * notas.GetLength(1);

        for (int i = 0; i < notas.GetLength(0); i++)
        {
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                sumaTotal += notas[i, j];
            }
        }

        double promedio = sumaTotal / totalNotas;
        Console.WriteLine($"\nEl promedio general del grupo es: {promedio}");
    }

}
