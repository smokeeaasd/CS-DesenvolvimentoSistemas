using System;

namespace DescontoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade comprada: ");
            Double quantidade = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Informe o valor unitário: ");
            Double valor_unitario = Double.Parse(Console.ReadLine());

            Double total = valor_unitario * quantidade;
            Console.WriteLine();

            if (quantidade > 100)
            {
                Console.Write("Informe o % de desconto: ");
                Double desconto = Double.Parse(Console.ReadLine());

                total -= (total / 100 * desconto);
            }
            total = Math.Round(total, 2);
            Console.WriteLine($"O valor total da compra é: {total:C}");

            Console.ReadKey();
        }
    }
}
