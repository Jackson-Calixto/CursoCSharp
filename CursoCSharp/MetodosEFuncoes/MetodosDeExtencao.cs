using System;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtencoesDeTipos
    {
        public static int Soma(this int numero, int outroNumero)
        {
            return numero + outroNumero;
        }

        public static double Subtracao(this double numero, int outroNumero)
        {
            return numero - outroNumero;
        }
    }
    class MetodosDeExtencao
    {
        public static void Executar()
        {
            int num = 5;
            double numReal = 5;

            Console.WriteLine(num.Soma(3));
            Console.WriteLine(numReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.0.Subtracao(4));
        }
    }
}