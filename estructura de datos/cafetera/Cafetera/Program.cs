using System;
using static System.Net.Mime.MediaTypeNames;

namespace Cafetera
{
    internal class Program
    {
        public class cafetera 
        { 
            public int _cpm { set; get; }
            public int _ca { set; get; }

            public cafetera() 
            {
                this._cpm = 1000;
                this._ca = 0;
            }

            public cafetera (int capmax)
            {
                this._cpm = capmax;
                this._ca = capmax;
            }

            public cafetera(int capmax, int cantac)
            {
                this._cpm = capmax;
                if (cantac > capmax)
                {
                    cantac = capmax;
                }
                this._ca = cantac;
            }

            public void llenar_cafetera()
            {
                this._ca = this._cpm;
            }

            public void vaciar_cafetera()
            {
                this._ca = 0;
            }

            public void servir_taza(int cant)
            {
                if (cant < this._ca)
                {
                    this._ca = this._ca - cant;
                }
                else
                {
                    this._ca = 0;
                }
            }

            public void agregar_cafe(int cant)
            {
                this._ca = this._ca + cant;
                if(this._ca > this._cpm)
                {
                    this._ca = this._cpm;
                }
            }

            public string Imprimir()
            {
                string txt;
                txt = "la cantidad de la cafetera es:" + this._ca;
                return txt;
            }

        }

            static void Main(string[] args)
        {
            cafetera c1, c2, c3;
            c1 = new cafetera(900,50);
            c2 = new cafetera(900,200);
            c3 = new cafetera(900,600);



            Console.WriteLine(c1.Imprimir());
            Console.WriteLine(c2.Imprimir());
            Console.WriteLine(c3.Imprimir());
        }
    }
}
