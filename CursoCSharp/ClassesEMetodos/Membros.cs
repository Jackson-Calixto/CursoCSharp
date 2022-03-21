using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Jackson";
            pessoa1.Idade = 42;

            //Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade}");

            pessoa1.ApresentarNoConsole();
            pessoa1.Zerar();
            pessoa1.ApresentarNoConsole();

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Calixto";
            pessoa2.Idade = 42;

            var apresentacaoDaPessoa = pessoa2.Apresentar();
            Console.WriteLine(apresentacaoDaPessoa.Length);
            Console.WriteLine(apresentacaoDaPessoa);
        }
    }
}