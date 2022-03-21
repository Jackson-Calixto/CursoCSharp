﻿using System;
using System.IO;

namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Boracha Branca;2.89;27");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path+".txt"))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}