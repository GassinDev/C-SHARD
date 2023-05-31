using System;

namespace Ejercicio_ObjetosClases_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hora h = new Hora(3600);
            //Console.WriteLine(h);

            Console.WriteLine("Que quieres hacer:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Me das los segundos y te doy las hora,minutos y segundos ");
            Console.WriteLine("2. Suma las horas");
            Console.WriteLine("3. Resta las horas");
            Console.WriteLine("4. SumaHoras");
            Console.WriteLine("5. SumaMinutos");
            Console.WriteLine("6. SumaSegundos");

            int opcion;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Bien, Dame los segundos: ");
                        int segundos;
                        segundos = int.Parse(Console.ReadLine());
                        Hora h = new Hora(segundos);
                        Console.WriteLine(h);
                    }
                    break;

                case 2:
                    {
                        int h1, h2;
                        Console.WriteLine("Dame la primera hora");
                        h1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dame la otra hora");
                        h2 = int.Parse(Console.ReadLine());

                        Hora h = new Hora(h1 + h2);
                        Console.WriteLine(h);
                    }
                    break;

                case 3:
                    {
                        int h1, h2;
                        Console.WriteLine("Dame la primera hora");
                        h1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dame la otra hora");
                        h2 = int.Parse(Console.ReadLine());

                        Hora h = new Hora(h1 - h2);
                        Console.WriteLine(h);
                    }
                    break;

                case 4:
                    {
                        int h1, h2;
                        Console.WriteLine("Dame la primera hora en segundos");
                        h1 = int.Parse(Console.ReadLine());

                        Hora hora = new Hora(h1);

                        Console.WriteLine("Dame la otra hora en este caso en horas");
                        h2 = int.Parse(Console.ReadLine());

                        hora.SumaHoras(h2);
                        Console.WriteLine(hora);
                        
                        
                    }
                    break ;

                case 5:
                    {
                        int h1, h2;
                        Console.WriteLine("Dame la primera hora en segundos");
                        h1 = int.Parse(Console.ReadLine());

                        Hora hora = new Hora(h1);

                        Console.WriteLine("Dame la otra hora en este caso en minutos");
                        h2 = int.Parse(Console.ReadLine());

                        hora.SumaMinutos(h2);
                        Console.WriteLine(hora);


                    }
                    break;

                case 6:
                    {
                        int h1, h2;
                        Console.WriteLine("Dame la primera hora en segundos");
                        h1 = int.Parse(Console.ReadLine());

                        Hora hora = new Hora(h1);

                        Console.WriteLine("Dame la otra hora en este caso en segundos");
                        h2 = int.Parse(Console.ReadLine());

                        hora.SumaSegundos(h2);
                        Console.WriteLine(hora);


                    }
                    break;
            }
        }
    }
}
