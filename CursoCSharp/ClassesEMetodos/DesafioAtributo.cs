﻿using System;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar variável 'a' dentro do método Executar!
            Console.WriteLine(new DesafioAtributo().a);
        }
    }
}