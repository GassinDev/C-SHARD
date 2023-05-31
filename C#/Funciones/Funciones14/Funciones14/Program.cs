using System;

namespace Funciones14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = leeNatural();
            Console.WriteLine("El número es " + n);
        }

        static int leeNatural()
        {
            int n;
            Console.WriteLine("Dime un número: ");
            n = int.Parse(Console.ReadLine());
            while()// el número esté mal
            {
                // lo vuelves a pedir
            }
            

            return n;
        } 

    }
}
