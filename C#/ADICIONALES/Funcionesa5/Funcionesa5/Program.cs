using System;

namespace Funcionesa5
{
    class Program
    {
        static void TriangulosEstrellitas()
        {
            int n,i,j;

            Console.WriteLine("Dame un número entre 3 y 20");
            n = int.Parse(Console.ReadLine());
            if (n < 3 || n > 20)
            {
                Console.WriteLine("Error");


            }
            else
            {
                for ( j=0;j<=n-1;j++)
                {
                   
                   
                    for ( i = 0; i < j; i++)
                    {

                        Console.Write("*");
                    }
                    Console.WriteLine("*");

                }
                   
                

                
            
            
            
            
            
            
            }
        
        
        
        
        }
        static void Main(string[] args)
        {
            // . Escribe la función trianguloEstrellitas. La función te pedirá un número que deberá ser
            //como mínimo el número 3 y como máximo el 20.Si el número no es correcto, escribirá
            //“ERROR”. La función escribirá por pantalla una pirámide a base de estrellitas como la
            //del ejemplo. La función deberá funcionar para cualquier número entre 3 y 20(o sea,
            //nada de escribir las estrellitas a mano).


            TriangulosEstrellitas();
           
        }
    }
}
