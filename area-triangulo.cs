// Programa para calcular el área de varios triángulos dados sus lados.
using System;

class Program
{
    // Función para calcular el área de un triángulo dados sus tres lados
    static double CalcularAreaTriangulo(double a, double b, double c)
    {
        double p = (a + b + c) / 2; // Semiperímetro
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static void Main()
    {
        Console.WriteLine("Calculadora de área de triángulos");

        while (true)
        {
            Console.Write("Ingrese los lados del triángulo separados por espacios (o escriba 'salir' para terminar): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "salir") break;

            string[] lados = input.Split(' ');
            if (lados.Length == 3 && double.TryParse(lados[0], out double a) && double.TryParse(lados[1], out double b) && double.TryParse(lados[2], out double c))
            {
                Console.WriteLine($"El área del triángulo es: {CalcularAreaTriangulo(a, b, c):F2}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Inténtelo de nuevo.");
            }
        }
    }
}