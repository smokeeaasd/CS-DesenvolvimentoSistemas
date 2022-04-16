using System;

namespace CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Celsius para Fahrenheit";
            double celsius;
            double fahrenheit;

            Console.Write("Informe a temperatura em graus Celsius (°C): ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine();

            Console.Write($"Temperatura em Fahrenheit (°F): {fahrenheit:f2}");

            Console.ReadKey();
        }
    }
}
