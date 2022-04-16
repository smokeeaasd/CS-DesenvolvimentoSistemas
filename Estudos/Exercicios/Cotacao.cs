using System;

namespace Cotacao
{
    internal class Program
    {
        static string input()
        {
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do Dólar: ");
            float cotacao_dolar = float.Parse(input());

            Console.Write("Digite a cotação do Euro: ");
            float cotacao_euro = float.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do Ouro: ");
            float cotacao_ouro = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o valor a ser investido: ");
            float valor_investido = float.Parse(Console.ReadLine());

            float dolar = valor_investido / cotacao_dolar;
            float euro = valor_investido / cotacao_euro;
            float ouro = valor_investido / cotacao_ouro;
            Console.WriteLine();

            Console.WriteLine($"Valor em dólar: {dolar:F}");
            Console.WriteLine($"Valor em euro: {euro:F}");
            Console.WriteLine($"Valor em ouro: {ouro:F}");

            Console.ReadKey();
        }
    }
}