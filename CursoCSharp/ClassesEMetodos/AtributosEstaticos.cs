using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;  
            Desconto = desconto;
        }
        public Produto(){}
        public double CalcularPreco()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.5 //Atributo da Classe e não da Instância
            };

            Produto.Desconto = 0.5;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularPreco()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularPreco()}");

            Produto.Desconto = 0.02;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularPreco()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularPreco()}");
        }
    }
}