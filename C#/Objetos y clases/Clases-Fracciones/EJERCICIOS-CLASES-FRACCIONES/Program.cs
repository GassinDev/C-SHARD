using System;

namespace EJERCICIOS_CLASES_FRACCIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion f = new Fraccion(10, 5);
            Fraccion f2 = new Fraccion(2, 2);
            //Console.WriteLine(f);
            //f.Simplificar();
            //Console.WriteLine(f);
            Fraccion f3 = new Fraccion(1, 1);
            f3 = f * f2;
            Console.WriteLine(f3);                
            

        }
    }
}
