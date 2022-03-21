using System;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        public class Moto
        {
            private string _marca;
            private string _modelo;
            private int _cilindrada;

            public Moto(string marca, string modelo, int cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }

            public Moto()
            {

            }

            public string GetMarca()
            {
                return _marca;
            }

            public void SetMarca(string marca)
            {
                _marca = marca;
            }
            public string GetModelo()
            {
                return _modelo;
            }

            public void SetModelo(string modelo)
            {
                _modelo = modelo;
            }
            public int GetCilindrada()
            {
                return _cilindrada;
            }

            public void SetCilindrada(int cilindrada)
            {
                if (_cilindrada > 0)
                {
                    _cilindrada = cilindrada;
                }
            }
        }
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", -636);

            Console.WriteLine($"{moto1.GetMarca()} {moto1.GetModelo()} {moto1.GetCilindrada()}");

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetMarca("CG Titan");
            moto2.SetCilindrada(-150);

            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
        }
    }
}