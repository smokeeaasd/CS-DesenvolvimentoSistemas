using System;

namespace Circulo
{
    internal class Program
    {
        static string input()
        {
            return Console.ReadLine();
        }
        static float toFloat(string data)
        {
            return float.Parse(data);
        }
        static void Main(string[] args)
        {
            Console.Write("Informe o raio do circulo: ");
            double raio = toFloat(input());

            double area = Math.PI * Math.Pow(raio, 2);
            double diametro = 2 * raio;
            double perimetro = diametro * Math.PI;

            Console.WriteLine();

            Console.WriteLine($"A área do círculo é: {area:f1}");
            Console.WriteLine($"O diâmetro do círculo é: {diametro:f1}");
            Console.WriteLine($"O perímetro do círculo é: {perimetro:f1}");

            Console.ReadKey();
        }
    }
}
