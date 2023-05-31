using System;

namespace EjerciciosAdicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Dame la temperatura(Centigrados) que quieres calcular:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame la temperatura(Fahrenheit) que quieres calcular:");
            b = double.Parse(Console.ReadLine());




            Console.WriteLine(CentigradosAFahrenheit(a));
            Console.WriteLine(FahrenheitACentigrados(b));

        }



        static double CentigradosAFahrenheit(double a)
        {
            double resultado;

            resultado = (1.8 * a) + 32;

            return resultado;
        }

        static double FahrenheitACentigrados (double b)
        {
            double resultado1;

            resultado1 = (b - 32) / 1.8;

            return resultado1;
        }
    }

}
