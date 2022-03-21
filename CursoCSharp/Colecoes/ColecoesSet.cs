using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Gama of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10),
                livro
            };

            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); // Set é uma estrutura não indexada.

            foreach (var item in carrinho)   
            {
                //Console.WriteLine(carrinho.IndexOf(item)); // Set é uma estrutura não indexada.
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.WriteLine(carrinho.IndexOf(livro)); // Set é uma estrutura não indexada.
        }
    }
}