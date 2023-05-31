using System;

namespace BucleWhile18
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, n, suma;
            double media;

            cont = 0;
            suma = 0;

            Console.WriteLine("Dime un número (escribe un negativo para terminar):");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                suma = suma + n;
                cont++;

                Console.WriteLine("Dime un número (escribe un negativo para terminar):");
                n = int.Parse(Console.ReadLine());
            }
            media = suma / cont;
            Console.WriteLine("La media es " + media);
        }
    }
}
