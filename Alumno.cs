class Alumno{

    public static void NombreNotas(string[] alumnos, int[,] notas){
        for(int i = 0; i < 2; i++){
            Console.WriteLine($"Ingrese el nombre del alumno {i+1}:");
            alumnos[i] = Console.ReadLine();
            for(int j = 0; j < 2; j++){
                Console.WriteLine($"Indique la nota número {j+1} del alumno {alumnos[i]}");
                notas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }  
    }
}