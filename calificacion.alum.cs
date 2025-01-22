// Programa para calcular la calificación total de un alumno
using System;

class Calificaciones
{
    // Función para calcular la calificación total
    static double CalcularCalificacion(double pr, double ex, double ta)
    {
        return pr * 0.55 + ex * 0.30 + ta * 0.15;
    }

    static void Main()
    {
        Console.WriteLine("Calculadora de calificación total");

        Console.Write("Ingrese la calificación de prácticas: ");
        double practicas = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación del examen: ");
        double examen = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación de tareas: ");
        double tareas = double.Parse(Console.ReadLine());

        Console.WriteLine($"La calificación total es: {CalcularCalificacion(practicas, examen, tareas):F2}");
    }
}
