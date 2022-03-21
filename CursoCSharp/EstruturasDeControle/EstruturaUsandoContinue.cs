using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaUsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;

            Console.WriteLine($"Numeros pares entre 1 e {intervalo}!");

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}