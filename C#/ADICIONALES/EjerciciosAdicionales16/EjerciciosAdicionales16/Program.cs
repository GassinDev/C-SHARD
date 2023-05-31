using System;

namespace EjerciciosAdicionales16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime un número:");
            n = int.Parse(Console.ReadLine());

            DescomponerFactoresPrimos(n);
        }


        static void DescomponerFactoresPrimos (int n)
        {
            int i = 1, resultado;
            
          while (n % i == 0)
            {
               for (i = 1; i < n; i--)
                {
                    resultado = n / i;

                    resultado = resultado / i;
                    
                }
                Console.Write(resultado + " x ");
                i++;
            }
                


            
            

            
            
           
        }
    }
}




