using System;

namespace MásBucles41
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, divisores = 0;

            for (n = 2; n <= 1000; n++)
            {
                divisores = 0;

                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        divisores++;
                        break;
                    }
                }
                
                if (divisores == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
