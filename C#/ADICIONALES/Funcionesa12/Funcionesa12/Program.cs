using System;

namespace Funcionesa12
{
    class Program
    {
        static void Romboide(int longitud, int altura)
        {
            int i, j;
            for (j = 0; j <=  altura-1; j++)
            {
                for (i = 0; i <  altura - j; i++)
                {

                    Console.Write(" ");
                }

                for (i = 0; i <= longitud-1  ; i++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("");

            }



        }
        static void Main(string[] args)
        {
            //2.Escribe la función romboide, que nos pintará un romboide con asteriscos.Habrá que
            //pasarle dos parámetros: la altura y la longitud.La longitud será el número de asteriscos
            //que hay en cada piso y la altura el número de pisos que tendrá.
            int longitud,altura;

            Console.WriteLine("Dime la altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime la longitud");
            longitud = int.Parse(Console.ReadLine());


            Romboide(longitud,altura);
            
        }
    }
}
