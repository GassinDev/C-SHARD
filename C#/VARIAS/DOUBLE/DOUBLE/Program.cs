using System;

namespace DOUBLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int doble;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            doble = n * 2;

            Console.WriteLine("El doble es " + doble);
        }
    }
}
