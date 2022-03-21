using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out var nota);

            var notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            const double tolerance = 0;
            Console.WriteLine("Perfeito? {0}", Math.Abs(nota - 10.0) < tolerance);
            Console.WriteLine("Tem como melhorar? {0}", Math.Abs(nota - 10.0) > tolerance);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota < 3.0);
        }
    }
}
