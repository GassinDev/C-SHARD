using System;

namespace Preguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer una cadena

            int edad; 


            Console.WriteLine("¿ Cuántos años tienes?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Tienes " + edad + " años");

            // Leer reales

            double euros;

            Console.WriteLine("¿Cuánto cuesta el café con tostada?");
            euros = double.Parse(Console.ReadLine());
            Console.WriteLine("El café vale " + euros);

            // Leer caracteres 

            char letra;

            Console.WriteLine("Escribe una letra");
            letra = Console.ReadLine()[0];
            Console.WriteLine(letra);

            char letras = 'a';
            string cadenaa = "a";
        }
    }
}
