using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano); 
        }
        public static void Executar()
        {
            Formatar(ano:2022, mes:6, dia:1);
        }
    }
}