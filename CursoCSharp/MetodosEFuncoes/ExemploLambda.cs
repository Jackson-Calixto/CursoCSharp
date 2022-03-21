using System;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            // Action é uma função void sem return
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            // Action também pode ter parametros
            Action<string> algoNoConsoleComParametro = (str) =>
            {
                Console.WriteLine("Lambda com C#!" + str);
            };

            algoNoConsoleComParametro("!!");

            // Func é uma função com return obrigatório
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // Ultimo tipo dentro de <tipo1, tipo2, tipon> é o tipo do retorno da função
            // Nome da variável = (parametro) => sentença ou bloco {}
            //Func<int, string> coversorHex = (numero) => numero.ToString("X");
            // Quando há apenas um parâmetro não precisa de parenteses (numero)
            // E quando é apenas uma sentença, não usando bloco {} o return está implicito
            //Func<int, string> coversorHex = numero => numero.ToString("X");
            // Ao usar bloco {} é obrigatório usar return
            Func<int, string> coversorHex = numero =>
            {
                return numero.ToString("X");
            };

            Console.WriteLine(coversorHex(240));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(18, 3, 2022));
        }
    }
}
