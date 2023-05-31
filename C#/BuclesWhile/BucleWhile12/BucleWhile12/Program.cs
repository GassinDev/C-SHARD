using System;

namespace BucleWhile12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, opcion;
            Console.WriteLine("Si quieres numeros pares pulsa 1, si quieres numeros impares pulsa 2");
            opcion = int.Parse(Console.ReadLine());

            if(opcion == 1)
            {
                n = 0;
                while (n <= 10)
                {
                    
                    Console.WriteLine(n);
                    n = n + 2;
                }
            }
            else
            {
                if(opcion == 2){
                    n = 1;
                    while (n < 10)
                    {
                        Console.WriteLine(n);
                        n = n + 2;
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
