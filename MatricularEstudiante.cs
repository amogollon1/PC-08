using System;
using System.Linq.Expressions;
public class Program
{
    public static void Main()
    {
        string nombre, carrera;
        int edad, carnet, notaAdmision;

        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Ingrese su edad: ");
            if (int.TryParse(Console.ReadLine(), out edad) && edad > 0)
            {
                break;
            }
            Console.WriteLine("Edad inválida. Intente de nuevo.");
        }

        Console.WriteLine("Ingrese su carrera: ");
        carrera = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("Ingrese su carnet: ");
            if (int.TryParse(Console.ReadLine(), out carnet))
                break;
            Console.WriteLine("Carnet inválido. Intente de nuevo.");
        }
        while (true)
        {
            Console.WriteLine("Ingrese su nota de admisión: ");
            if (int.TryParse(Console.ReadLine(), out notaAdmision) && notaAdmision >= 0 && notaAdmision <= 100)
                break;
            Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
        }

        Estudiante estudiante = new Estudiante(nombre, edad, carrera, carnet, notaAdmision);
        estudiante.MostrarResumen();
        estudiante.PuedeMatricular();
    }
}
public class Estudiante
{
    public string nombre, carrera;
    public int edad, carnet, notaAdmision;

    public Estudiante(string nombre_, int edad_, string carrera_, int carnet_, int notaAdmision_)
    {
        this.nombre = nombre_;
        this.edad = edad_;
        this.carrera = carrera_;
        this.carnet = carnet_;
        this.notaAdmision = notaAdmision_;
    }
    public void MostrarResumen()
    {
        Console.WriteLine("\nDatos del estudiante:");
        Console.WriteLine($"Nombre: {this.nombre}");
        Console.WriteLine($"Edad: {this.edad}");
        Console.WriteLine($"Carrera: {this.carrera}");
        Console.WriteLine($"Carnet: {this.carnet}");
        Console.WriteLine($"Resultado de admisión: {this.notaAdmision}");
    }
    public bool PuedeMatricular()
    {
        bool notaValida = this.notaAdmision >= 75;
        bool carnetValido = this.carnet.ToString().EndsWith("2025");

        if (notaValida == true && carnetValido == true)
        {
            Console.WriteLine("\nCarnet válido. Examen aprobado.\nEl estudiante fue admitido.");
            return true;
        }
        else if (notaValida == true && carnetValido != true)
        {
            Console.WriteLine("\nCarnet inválido. Examen aprobado.\nEl estudiante no fue admitido.");
            return false;
        }
        else if (notaValida != true && carnetValido != true)
        {
            Console.WriteLine("\nCarnet inválido. Examen no aprobado.\nEl estudiante no fue admitido.");
            return false;
        }
        return false;
    }
}