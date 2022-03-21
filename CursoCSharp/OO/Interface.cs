using System;
using System.Collections.Generic;

namespace CursoCSharp.OO
{
    // classe concret precisa ter 100% do métodos implementados
    // classe abtract pode ter de 0 a 100% dos métodos implementados e oque faltar precisa implementar na classe concret herdeira
    // interface      precisa ser 100% não implementada e precisa implementar na classe concret herdeira
    interface Teste
    {
        bool Bla(string a);
    }
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool Bla(string a)
        {
            throw new NotImplementedException();
        }
    }
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>()
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),    
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = null;

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}