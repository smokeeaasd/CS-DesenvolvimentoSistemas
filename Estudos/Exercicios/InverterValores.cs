using System;

namespace InverterValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Insira o valor de \"a\": ");
            var A = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira o valor de \"b\": ");
            var B = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine(
                $"Valores antigos\n" +
                $"A = {A}\n" +
                $"B = {B}\n");

            var armazenar = A;
            A = B;
            B = armazenar;

            Console.WriteLine(
                $"Valores atualizados\n" +
                $"A = {A}\n" +
                $"B = {B}");
            Console.ReadKey();
        }
    }
}
