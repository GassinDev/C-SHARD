using System;

namespace BuclesWhile14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;

            Console.WriteLine("Dime un número:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime un número mayor que el anterior:");
            n2 = int.Parse(Console.ReadLine());

            if (n < n2)
            {
                while (n <= n2)
                {
                    Console.WriteLine(n);
                    n++;
                }
            }
            else
            {
                while (n2 <= n)
                {
                    Console.WriteLine("Tiene que ser el segundo mayor al primero");
                    n2 = int.Parse(Console.ReadLine());
                }
                if (n < n2)
                {
                    while (n <= n2)
                    {
                        Console.WriteLine(n);
                        n++;
                    }
                }





            }
        }
    }
}
