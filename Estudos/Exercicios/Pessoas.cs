using System;

namespace ContagemPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int homens = 0;
            int mulheres = 0;
            String sexo;

            Console.Write("Informe o sexo da primeira pessoa (M/F): ");
            sexo = Console.ReadLine().ToUpper();

            if (sexo == "M") homens++;
            if (sexo == "F") mulheres++;

            Console.WriteLine();

            Console.Write("Informe o sexo da segunda pessoa (M/F): ");
            sexo = Console.ReadLine().ToUpper();

            if (sexo == "M") homens++;
            if (sexo == "F") mulheres++;

            Console.WriteLine();

            Console.Write("Informe o sexo da terceira pessoa (M/F): ");
            sexo = Console.ReadLine().ToUpper();

            if (sexo == "M") homens++;
            if (sexo == "F") mulheres++;

            Console.WriteLine();

            Console.Write("Informe o sexo da quarta pessoa (M/F): ");
            sexo = Console.ReadLine().ToUpper();

            if (sexo == "M") homens++;
            if (sexo == "F") mulheres++;

            Console.WriteLine();

            Console.WriteLine($"Contagem de homens: {homens}\n" +
                $"Contagens de mulheres: {mulheres}");

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
