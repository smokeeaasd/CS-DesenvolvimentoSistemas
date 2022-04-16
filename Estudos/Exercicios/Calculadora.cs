using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o primeiro número: ");
            Double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo número: ");
            Double num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite a operação: ");
            String operacao = Console.ReadLine();

            double res;
            switch (operacao)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {res}");
                break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {res}");
                break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine($"{num1} - {num2} = {res}");
                break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine($"{num1} - {num2} = {res}");
                break;

                case "^":
                    res = Math.Pow(num1, num2);
                    Console.WriteLine($"{num1} ^ {num2} = {res}");
                break;

                default:
                    Console.WriteLine("Insira uma operação válida.");
                break;
            }

            Console.ReadKey();
        }
    }
}
