using System;
using System.Security.Cryptography.X509Certificates;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        // Método de Classe ou Método Estático!!!
        public static int Multiplicar(int a, int b) // Estático pertence a classe
        {
            return a * b;
        }

        // Método de Instância!!!
        public int Somar(int a, int b) //Não estático pertence a instância
        {
            return a + b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {

            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 3));
            //Console.WriteLine(CalculadoraEstatica.Somar(2, 2));//Não estático pertence a instância e não pode ser usado em uma classe

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 3));
            //Console.WriteLine(calc.Multiplicar(2, 2));// Estático pertence a classe e não pode ser usado em uma instância
        }
    }
}