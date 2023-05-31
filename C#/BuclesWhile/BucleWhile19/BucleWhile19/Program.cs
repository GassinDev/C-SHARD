using System;

namespace BucleWhile19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, aprobados = 0, suspensos = 0, numeroAlumnos = 30;
            double nota;

            i = 0;
            
            while ( i < numeroAlumnos)
            {
                Console.WriteLine("Dime la nota del alumno " + i + " :");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 5)
                {
                    aprobados++;
                }
                else
                {
                    suspensos++;
                }
                i++;
            }
            Console.WriteLine("Hay " + aprobados + " aprobados y " + suspensos + " suspensos.");
        }
    }
}
