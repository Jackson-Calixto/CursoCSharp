using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            //Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto.ToString("C", new CultureInfo("pt-BR"))}");

            //IMC
            double peso = 86.9;
            double altura = 1.74;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {IMC}");

            //Número Par/Impar
            int par = 26;
            int impar = 53;
            Console.WriteLine("{0}%2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}%2 tem resto {1}", impar, impar % 2);
        }
    }
}
