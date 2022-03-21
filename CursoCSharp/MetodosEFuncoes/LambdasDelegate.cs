using System;

namespace CursoCSharp.MetodosEFuncoes
{

    class LambdasDelegate
    {
        // delegate Define o tipo do return e os tipos dos parametros a serem usados no Lambda
        delegate double Operacao(double x, double y);
        public static void Executar()
        {
            Operacao sum = (d, d1) => d + d1;
            Operacao sub = (d, d1) => d - d1;
            Operacao mul = (d, d1) => d * d1;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mul(12, 8));
        }
    }
}