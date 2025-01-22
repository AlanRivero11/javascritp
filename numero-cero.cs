// Programa para leer e imprimir números hasta que se ingrese un cero
using System;

class SerieNumeros
{
    static void Main()
    {
        Console.WriteLine("Ingrese números distintos de cero. Finalice con 0.");

        int contador = 0;
        while (true)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0) break;

            Console.WriteLine($"Número ingresado: {numero}");
            contador++;
        }

        Console.WriteLine($"Se ingresaron {contador} números.");
    }
}