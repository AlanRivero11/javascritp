// Programa para leer un número, multiplicarlo por 2 y mostrarlo
using System;

class Multiplicador
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado es: {numero * 2}");
    }
}
