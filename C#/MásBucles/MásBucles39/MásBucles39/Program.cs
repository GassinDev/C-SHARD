using System;

namespace MásBucles39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            bool encontrado;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            i = a;
            encontrado = false;

            while(!encontrado)
            {
                if ((i % a == 0) && (i % b == 0))
                {
                    Console.WriteLine(i);
                    encontrado = true;

                }
                i++;
            }

        }
    }
}
