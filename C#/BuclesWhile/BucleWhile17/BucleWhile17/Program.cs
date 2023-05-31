using System;

namespace BucleWhile17
{
    class Program
    {
        static void Main(string[] args)
        {
           int i, suma;

            suma = 0;
            i = 2;

            while (i <= 1000)
            {
                suma = (suma + i);
                i = i + 2;            
            }
            Console.WriteLine(suma);
        }
    }
}
