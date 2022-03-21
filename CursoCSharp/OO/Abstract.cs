using System;
using System.Collections.Generic;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {// Classe abstract não pode ser instanciada, usada como classe base a ser herdada
        public abstract string Assistente(); 
        // Método abstract precisa ser implementado na classe concret à herdar classe base abstract
        public string Tocar()
        {
            return "Trim Trim Trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung(),
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}