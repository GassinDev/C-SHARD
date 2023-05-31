using System;

namespace EjerciciosAdicionales18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime cuántos números quieres sumar xurrita:");
            n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("AMOVE TRINCAPOLLA COMO ME VA A DECI QUE SUME - ALGO TONTO");
                Console.WriteLine("Dime cuántos números quieres sumar xurrita:");
                n = int.Parse(Console.ReadLine());
  
            }

            Console.WriteLine(SumaNumeros(n));




        }


        static int SumaNumeros(int n)
        {

            int suma = 0, i, numero;

            
            
            for (i = 0; i < n; i++ )
            {
                
                Console.WriteLine("Dime números:");
                numero = int.Parse(Console.ReadLine());


                if (numero < 0)
                {
                    Console.WriteLine("Dime números:");
                    numero = int.Parse(Console.ReadLine());

                    
                }

                suma = suma + numero;

                
            }

            return suma;
        }





    }

     
}
