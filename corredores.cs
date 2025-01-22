// Programa para calcular la velocidad de los corredores
using System;

class VelocidadCorredores
{
    // Función para calcular la velocidad en m/s
    static double CalcularVelocidad(int minutos, int segundos)
    {
        double tiempoTotalSegundos = minutos * 60 + segundos;
        return 1500 / tiempoTotalSegundos;
    }

    static void Main()
    {
        Console.WriteLine("Calculadora de velocidad para corredores de 1500 metros");

        while (true)
        {
            Console.Write("Ingrese el tiempo del corredor (minutos segundos) o 0 0 para terminar: ");
            string[] entrada = Console.ReadLine().Split(' ');

            int minutos = int.Parse(entrada[0]);
            int segundos = int.Parse(entrada[1]);

            if (minutos == 0 && segundos == 0) break;

            Console.WriteLine($"Tiempo: {minutos} minutos {segundos} segundos");
            Console.WriteLine($"Velocidad: {CalcularVelocidad(minutos, segundos):F2} m/s");
        }
    }
}
