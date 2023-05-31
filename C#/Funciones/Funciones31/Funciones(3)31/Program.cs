using System;

namespace Funciones_3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo;

            Console.WriteLine("Dame las horas:");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame los minutos:");
            minuto = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame los segundos:");
            segundo = int.Parse(Console.ReadLine());

            Console.WriteLine(EscribeHoraBonita(hora, minuto, segundo));
        }

        static string EscribeHoraBonita (int hora, int minuto, int segundo)
        {
            string resultado, horas, minutos, segundos;

            if (hora >= 10)
            {
                horas = hora + ":";

            }else
            {
                horas = "0" + hora + ":";
            }

            if (minuto >= 10)
            {
                minutos = minuto + ":";

            }
            else
            {
                minutos = "0" + minuto + ":";
            }

            if (segundo >= 10)
            {
                segundos = segundo + "";

            }
            else
            {
                segundos = "0" + segundo;
            }

               resultado = horas + minutos + segundos;

            return resultado;
        }
    }
}
