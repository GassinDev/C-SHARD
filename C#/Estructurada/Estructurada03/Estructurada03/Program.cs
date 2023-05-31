using System;

namespace Estructurada03
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneda;
            double euros, pesetas;

            Console.WriteLine("Dime la moneda que quieres convertir ( euro/peseta)");
            moneda = Console.ReadLine();

            if (moneda == "euro")
            {
                Console.WriteLine("Dime los euros");
                euros = double.Parse(Console.ReadLine());
                pesetas = euros * 166.386;
                Console.WriteLine(euros + " euros son " + pesetas + " pesetas");

            }
            else

                if (moneda == "peseta")
            {
                Console.WriteLine("Dime las pesetas");
                pesetas = double.Parse(Console.ReadLine());
                euros = pesetas / 166.386;
                Console.WriteLine(pesetas + " pesetas son " + euros + " euros");
            }
            else
                Console.WriteLine("ERROR");
        }
    }
}
