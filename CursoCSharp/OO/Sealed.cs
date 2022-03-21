using System;

namespace CursoCSharp.OO
{
    class Sealed
    {
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1_407_033.65;
            }
        }

        //class SouFilho : SemFilho
        //{
            
        //}
        class Avo
        {
            public virtual bool HonrarNomeFamilia()
            { //Método virtual permite ser sobrescrito usando override
                return true;
            }
        }

        class Pai : Avo
        {
            public override sealed bool HonrarNomeFamilia()
            { //Método sealed não permite ser sobrescrito usando override
                return true;
            }
        }
        class Filho : Pai
        {
            //public override bool HonrarNomeFamilia()
            //{ //Método sealed não permite ser sobrescrito usando override
            //    return true;
            //}
            public new bool HonrarNomeFamilia()
            { //Método sealed não permite ser sobrescrito usando override
              //Mas permite ser ocultado usando new
                return false;
            }
        }
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            Filho filho = new Filho();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}