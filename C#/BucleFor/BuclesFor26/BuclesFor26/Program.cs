using System;

namespace BuclesFor26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, opcion;
            Console.WriteLine("Si quieres numeros pares pulsa 1, si quieres numeros impares pulsa 2");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                for (n = 0;  n <= 10; n = n + 2)
                {

                    Console.WriteLine(n);
                }
            }
            else
            {
                if (opcion == 2)
                {
                    for (n = 1; n < 10; n = n + 2)
                    {
                        Console.WriteLine(n);
                    }
                }
                else
                {
                    Console.WriteLine("Opcion Incorrecta");
                }
            }
        }
    }
}
