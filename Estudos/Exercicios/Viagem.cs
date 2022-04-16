using System;

namespace Viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Informe o valor do litro de combustível: ");
            float litro = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Informe a distância percorrida pelo veículo (KM): ");
            float distancia = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Informe a quantidade de KM que o seu veículo corre por Litro: ");
            float consumo = float.Parse(Console.ReadLine());

            float litros_gastos = (distancia / consumo);
            float total_gasto = (litros_gastos * litro);

            Console.WriteLine("");

            Console.WriteLine($"Preço do litro de combustível: {litro}");
            Console.WriteLine($"Distância percorrida: {distancia}");
            Console.WriteLine($"Consumo: {consumo}km/l");
            Console.WriteLine($"Total gasto na viagem: {total_gasto}");

            Console.ReadKey();
        }
    }
}
