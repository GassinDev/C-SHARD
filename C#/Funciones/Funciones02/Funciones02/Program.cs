using System;

namespace Funciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime un año ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(Bisiesto(n));

            if (Bisiesto(n))
            {
                Console.Write("BISIESTO");
            }else
            {
                Console.Write("NO BISIESTO");
            }
                

           

            
        }
        static bool Bisiesto(int anno)
        {
            bool bisiesto;
            
            if (anno % 4 == 0)
            {
                if(anno % 100 == 0)
                {
                    if (anno % 400 == 0)
                    {
                        bisiesto = true;
                    }
                    else
                    {
                        bisiesto = false;
                    }
                }
                else
                {
                    bisiesto = true;
                }

            }
            else
            {
                bisiesto = false;

            }

            return bisiesto;
        }
    }
}
