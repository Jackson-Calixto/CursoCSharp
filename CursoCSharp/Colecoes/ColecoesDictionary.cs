using System;
using System.Collections.Generic;
using System.IO;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homen-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine($"2004: {filmes[2004]}");
                filmes.TryGetValue(2004, out string filme);
                Console.WriteLine($"2004: {filme}");
            }

            Console.WriteLine(filmes.ContainsValue("Aminésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var value in filmes.Values)
            {
                Console.WriteLine(value);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme}");
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme}");
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}