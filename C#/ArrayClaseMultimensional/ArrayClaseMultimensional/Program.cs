using System;

namespace ArrayClaseMultimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];

            int[,] array2 = { { 1, 0, 12}, 
                              { 1, 8, 72}, 
                              { 2, 34, 1} };

            array[0, 0] = 10;

            Console.WriteLine(array2[2, 3]);

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {

                    Console.WriteLine(array2[i, j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {

                    Console.WriteLine(array2[i, j]);
                }
            }
            Console.WriteLine(array2.Rank);

        }

        static void EscribeArray3x4(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.WriteLine(a[i, j]);
                }
            }
        }
    }
}
