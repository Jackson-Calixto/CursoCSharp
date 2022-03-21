using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a); // Parâmetro de Entrada e Saída e a variável pode estar inicialisada!!!
            Console.WriteLine(a);

            AlterarOut(out int b); // Parâmetro de Somente Saída e a variável não pode estar inicialisada!!! 
            Console.WriteLine(b); 
        }
    }
}