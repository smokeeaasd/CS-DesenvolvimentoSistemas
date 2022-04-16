using System;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do primeiro aluno: ");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite a idade do segundo aluno: ");
            int idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite a idade do terceiro aluno: ");
            int idade3 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            float media = (idade1 + idade2 + idade3) / 3;

            Console.WriteLine($"A média das idades é de: {Math.Round(media, 0)}");

            Console.ReadKey();
        }
    }
}
