using System;
//crear una clase que permita trabajar con numeros complejos (parte real e imaginarias) incluyendo los siguientes metodos:
//constructor, suma, resta, multiplicacion y division y un metodo para imprimir el numero por pantalla.
namespace Numeros_complejos
{
    internal class Program
    {

        class NC 
        {
            public double Nreal;
            public double Nimag;

            public NC(double Nreal, double Nimag)
            {
                this.Nreal = Nreal;
                this.Nimag = Nimag;
            }

            public void sumar(double x, double y)
            {
                Nreal = Nreal + x;
                Nimag = Nimag + y;
            }

            public void resta(double x, double y)
            {
                Nreal = Nreal - x;
                Nimag = Nimag - y;
            }

            public void multiplicacion(double x, double y)
            {
                Nreal = Nreal * x;
                Nimag = Nimag * y;
            }

            public void division(double x, double y)
            {
                Nreal = Nreal / x;
                Nimag = Nimag / y;
            }

            public string imprimir()
            {
                return $"Número complejo: {Nreal} y {Nimag}";
            }

        }

        static void Main(string[] args)
        {
            NC A = new NC (6,7);
            NC B = new NC (10,5);

           
            B.sumar (A.Nreal, A.Nimag);
            Console.WriteLine (B.imprimir());
            
        }
    }
}
