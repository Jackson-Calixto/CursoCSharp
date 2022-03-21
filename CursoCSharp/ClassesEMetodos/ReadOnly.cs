using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime _nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            _nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return $"{_nascimento.Day:D2}/{_nascimento.Month:D2}/{_nascimento.Year:D4}";
        }
    }
    class ReadOnly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}