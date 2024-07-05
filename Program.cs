using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        //Crear una lista de estudiantes:

        List<Estudiante> Estudiantes = new List<Estudiante>()
        {
            new Estudiante("Angel", 20, 8.5),
            new Estudiante("Beto", 17, 7.0),
            new Estudiante("Carlos", 19, 0),
            new Estudiante("jose", 19, 0),
            new Estudiante("Pablo", 19, 0),

        };

        // Operaciones con expresiones lambda:

        var EstudiantesMayores = Estudiantes.Where(e => e.Edad > 18).ToList();

        var EstudiantesNotas = Estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();

        var OrdenAlfabetico = Estudiantes.OrderBy(e => e.Nombre).ToList();

        var PromedioNotas = Estudiantes.Average(e => e.Nota);

        //Mostramos informacion en la consola 

        Console.WriteLine("Estudiantes mayores de edad:");
        foreach (var estudiante in EstudiantesMayores)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
        }

        Console.WriteLine("\nEstudiante con la nota más alta:");
        Console.WriteLine($"Nombre: {EstudiantesNotas.Nombre}, Nota: {EstudiantesNotas.Nota}");

        Console.WriteLine("\nEstudiantes ordenados por nombre:");
        foreach (var estudiante in OrdenAlfabetico)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
        }

        Console.WriteLine($"\nPromedio de notas: {PromedioNotas}");
    }
}