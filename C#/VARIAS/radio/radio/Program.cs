using System;

namespace radio
{
    class Program
    {
        static void Main(string[] args)

        {
            double radio, area;
            Console.WriteLine("Dime el radio del círculo");
            radio = double.Parse(Console.ReadLine());

            area = 3.1415926535 * (radio * radio);

            Console.WriteLine("El área del círculo es " + area); 
        }
    }
}
