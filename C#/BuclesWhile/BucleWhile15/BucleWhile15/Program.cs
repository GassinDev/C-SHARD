using System;

namespace BuclesWhile15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2;

            Console.WriteLine("Dime un número:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime un número: ");
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
                while (n >= n2)
                {
                    Console.WriteLine(n);
                    n--;
                }
            }
            





            }
        }
    }


