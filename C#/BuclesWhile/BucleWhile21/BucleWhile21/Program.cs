using System;

namespace BucleWhile21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, mayor = int.MinValue, menor = int.MaxValue;
            double resultado = 0, media;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            while (i < 10)
            {
                Console.WriteLine("Dime un número");
                n = int.Parse(Console.ReadLine());

                if (n > mayor)
                {
                    mayor = n;
                }

                if (n < menor)
                {
                    menor = n;
                }
                resultado = resultado + n;

                i++;
            }
          
                media = resultado / 10;

                Console.WriteLine("El valor máximo es " + mayor);
                Console.WriteLine("El valor mínimo es " + menor);
                Console.WriteLine("La media aritmética es " + media);


            
        }
    }
}

