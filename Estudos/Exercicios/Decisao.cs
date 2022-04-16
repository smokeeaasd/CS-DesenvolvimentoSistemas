using System;

namespace Decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você gosta de programação? (S/N): ");

            String resposta = Console.ReadLine().ToUpper();

            String resultado = (resposta == "S") ? "SIM" : (resposta == "N") ? "NÃO" : "responde certo, na moral";

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}

