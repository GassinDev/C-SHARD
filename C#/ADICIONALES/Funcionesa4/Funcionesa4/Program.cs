using System;

namespace Funcionesa4
{
    class Program
    {
        static int Potencia2(int n)
        {
            int i,resultado=1;


            for ( i = 0; i < n; i++)
            {
                resultado = 2 * resultado;
            }

            return resultado;
        
        
        
        }
        static void Main(string[] args)
        {
            //Escribe una función potencia2 que te devuelva la potencia de 2 del número que le pasas
            //por parámetro(ambos enteros).El valor del parámetro tendrá que ser 0(un caso
            //especial) o un número positivo. Si se le manda un número negativo, la función devolverá
            //- 1.No se podrá utilizar la función Math.pow()(evidentemente).
            int n;

            Console.WriteLine("Dime un número al que elevar al dos");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Potencia2(n));
           
        }
    }
}
