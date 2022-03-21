using System;

namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }
    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int n = random.Next(-30, 30);

            if (n < 0)
            {
                throw new NegativoException("Número negativo... :(");
            }

            if (n % 2 == 1)
            {
                throw new ImparException("Valor impar... :(");
            }

            return n;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ImparException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}