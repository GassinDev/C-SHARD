using System;

namespace Funciones_3_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundo;

            Console.WriteLine("Dime los segundos");
            segundo = int.Parse(Console.ReadLine());

            Console.WriteLine(EscribeSegundosBonito(segundo));
        }

        static string EscribeSegundosBonito(int segundo)
        {
            int hora, minuto, resultado, resto;
                
                
            hora = segundo / 3600;
            resto = segundo % 3600;
            minuto = resto / 60;
            segundo = resto % 60;

            return EscribeHoraBonita(hora, minuto, segundo);
           
        }

    static string EscribeHoraBonita(int hora, int minuto, int segundo1)
    {
        string resultado, horas, minutos, segundos;

        if (hora >= 10)
        {
            horas = hora + ":";

        }
        else
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

        if (segundo1 >= 10)
        {
            segundos = segundo1 + "";

        }
        else
        {
            segundos = "0" + segundo1;
        }

        resultado = horas + minutos + segundos;

        return resultado;
    }

}
}
