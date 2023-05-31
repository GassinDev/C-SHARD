using System;

namespace Funciones_3_30
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

            Console.WriteLine(HoraASegundos(hora, minuto, segundo) + " segundos");
        }

        static int HoraASegundos(int hora, int minuto, int segundo)
        {
            int resultado;

            resultado = (hora * 3600) + (minuto * 60) + segundo;

            return resultado;
            
        }
    }
}
