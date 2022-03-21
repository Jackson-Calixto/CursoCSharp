using System;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);
        public static void Executar()
        {
            // Função anônima é a substituição do nome de uma função(string s) por delegate(string s)
            StringOperacao inverter = delegate(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}