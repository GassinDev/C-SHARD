using System;

namespace Funcionesa11
{
    class Program
    {
        static int Medio(int n1, int n2,int n3)
        {
            int medio, minimo, maximo;
           minimo= Minimo(n1, n2, n3);
           maximo = Maximo(n1, n2, n3);



            if (n1 != minimo && n1 != maximo)
            {

                medio = n1;

            }
            else
            {
                if (n2 != minimo && n2 != maximo)
                {

                    medio = n2;

                }
                else
                {

                    medio = n3;
                }
            
            
            
            }


            return medio;

        }

        static int Minimo(int n1, int n2, int n3)
        {
            //return Math.Min(n1, Math.Min(n2, n3));
            int minimo;

            minimo = n1;

            if (n2<n1 && n2<n3 )
            {

                minimo = n2;

            }
            else
            {

                if (n3 < n2 && n3<n1)
                {

                    minimo = n3;

                }
            
            
            }

            return minimo;





        }


        static int Maximo(int n1, int n2, int n3)
        {
            int maximo;

            maximo = n1;

            if (n2 > n1 && n2 > n3)
            {

                maximo = n2;

            }
            else
            {
                if (n3>n2 && n3>n1)
                {

                    maximo = n3;

                }
            
            
            }

            return maximo;
        
        
        
        
        }
        static void Main(string[] args)
        {

            // Escribe tres funciones que se llamarán maximo, medio y minimo.A cada una de las
            //funciones le pasaremos tres valores enteros(a, b, c).La función maximo nos devolverá
            //el mayor de los tres, la función minimo el menor de los tres y la función medio el del
            //medio.

            int n1, n2, n3;

            Console.WriteLine("Dime un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un número");
            n3 = int.Parse(Console.ReadLine());


            Console.WriteLine("El maximo es " + Maximo(n1, n2, n3));

            Console.WriteLine("El medio es " + Medio(n1, n2, n3));

            Console.WriteLine("El minimo es " + Minimo(n1, n2, n3));

          
           
        }
    }
}
