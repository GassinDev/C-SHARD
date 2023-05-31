using System;

namespace Funciones12
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, cm;

            Console.WriteLine(" Dime las pulgadas: ");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("Son " + pulgadasACentimetros(p) + " cm ");

            Console.WriteLine("Dime los centímetros: ");
            cm = double.Parse(Console.ReadLine());
            Console.WriteLine("Son " + centímetrosAPulgadas(cm) + " pulgadas ");
        }
        static double pulgadasACentimetros(double p)
        {
            double centimetros;

            centimetros = (p * 2.54);

            return centimetros;

        }
        static double centímetrosAPulgadas(double cm)
        {
            double pulgadas;

            pulgadas = (cm / 2.54);

            return pulgadas;

        }
    }
}

