using System;

namespace Funciones11
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h;

            Console.WriteLine(" Dime la base del triángulo: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(" Dime la altura del triángulo: ");
            h = double.Parse(Console.ReadLine());


            Console.WriteLine("El área del triángulo es " + Area(b, h) + " cm^2 ");
        }
        static double Area(double b, double h)
            {
            double areatriangulo;

            areatriangulo = ((b * h) / 2);

            return areatriangulo;
        }
    }
    
}
