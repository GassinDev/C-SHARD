using System;

namespace PIRAMIDE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Dime la altura del triángulo ( Min:3 y Max:20)");
            n = int.Parse(Console.ReadLine());

            while ((n < 3)||(n > 20))
            {
                Console.WriteLine("ERROR, ¿ ILLO ERES TONTO POLLA O QUE ? LEE BIEN!!!!");


                Console.Write("Dime la altura del triángulo ( Min:3 y Max:20)");
                n = int.Parse(Console.ReadLine());
            }

            Piramide(n);
            Piramide2(n);
        }

        static void Piramide (int n)
        {
            int lactual, espacio, aster;

            for (lactual = 1; lactual <= n; lactual++)
            {
                for (espacio =0; espacio < n - lactual; espacio++)
                {

                    Console.Write(" ");
                }

                for (aster = 0; aster < (lactual*2) - 1; aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void Piramide2(int n)
        {
            int lactual, espacio, aster;

            for (lactual = n - 1; lactual >= 0; lactual--)
            {
                for (espacio = 0; espacio < n - lactual; espacio++)
                {

                    Console.Write(" ");
                }

                for (aster = 0; aster < (lactual * 2) - 1; aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }






        }
    }
}
