using System;

namespace Funcionesa10
{
    class Program
    {
        static void EscribeSerieNumeros3()
        {
            int n1, n2, n3;

            Console.WriteLine("Dime un número entre 1 y 100");
            n1 = int.Parse(Console.ReadLine());

            while (n1 < 1 || n1 > 100)
            {
                Console.WriteLine("Dimelo bien ");
                n1 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Dime un número entre 1 y 100 que sea mayor que el primero");
            n2 = int.Parse(Console.ReadLine());

            while (n1 > n2 || 100 < n2)
            {
                Console.WriteLine("Dimelo bien ");
                n2 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Dime un número entre 1 y 100 que sea mayor que el primero y menor que el segundo");
            n3 = int.Parse(Console.ReadLine());

            while (n1 > n2 || n2 < n3)
            {
                Console.WriteLine("Dimelo bien ");
                n3 = int.Parse(Console.ReadLine());
            }
            for (int i = n1; i <= n3; i++)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine(" ");
            for (int i = n3; i <= n2; i++)
            {
                Console.Write(i+" ");

            }
        }
            static void Main(string[] args)
            {
                //. Escribe una función escribeSerieNumeros3 que nos pide tres números.El primero
                //tendrá que ser un número entre 1 y 100; si el número no es correcto, lo vuelve a pedir.
                //El segundo tendrá que ser un número entre 1 y 100 pero con la condición de que sea
                //mayor que el primero; lo volverá a pedir mientras no sea correcto. El tercero tendrá que
                //ser un número entre 1 y 100 con la condición de que sea mayor que el primero y menor
                //que el segundo; también lo volverá a pedir hasta que sea correcto.
                //Una vez que tengamos los tres números, nos escribirá por pantalla los números
                //comprendidos entre el primero y el tercero y en otra línea los números comprendidos
                //entre el tercero y el segundo. Mejor con un ejemplo:
                //Los tres números son 5, 12 y 7.Nos tendrá que escribir:
                //   5 6 7
                //7 8 9 10 11 12

                EscribeSerieNumeros3();
            }
        
    }
}