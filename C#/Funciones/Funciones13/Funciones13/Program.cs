using System;

namespace Funciones13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Dime la nota de tu examen: ");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("Uste estaría " + notaEnTexto(n));

        }

        static string notaEnTexto(double n)
        {
            // 0..5->suspenso, 5..6->suficiente, 6..7->bien, 7..9->notable, 9..10->sobresaliente

            string resultado;

            if (n < 0 || n > 10)
            {
                resultado = "No es una nota Válida";
            }
            else
            {
                if (n >= 5 && n < 6)
                {
                    resultado = "Suficiente";
                }
                else
                {
                    if (n >= 6 && n < 7)
                    {
                        resultado = "Bien";
                    }
                    else
                    {
                        if (n < 5)
                        {
                            resultado = "Suspenso";
                        }
                        else
                        {
                            if (n >= 7 && n < 9)
                            {
                                resultado = "Notable";
                            }
                            else
                            {
                                resultado = "Sobresaliente";
                            }
                        }
                    }
                }
            }

            return resultado;
        }

    }
}






