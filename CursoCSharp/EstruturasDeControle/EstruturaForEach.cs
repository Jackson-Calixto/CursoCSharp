﻿using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine();

            var alunos = new string[]  {"Ana", "Bia", "Jack"};
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}