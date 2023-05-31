using System;

namespace BucleFor25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, contador;
            
            for(contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(n);
                n = n + 2;
            }
        }
    }
}
