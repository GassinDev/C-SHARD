using System;

namespace MásBucles36
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, cont = 0;

            while ( cont < 10)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i);
                    cont++;
                }
                i++;
            }

        }
    }
}
