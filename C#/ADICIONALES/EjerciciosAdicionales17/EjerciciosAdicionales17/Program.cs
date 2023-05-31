using System;

namespace EjerciciosAdicionales17
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, dia, ano;

            Console.Write("Dime dia:");
            dia = int.Parse(Console.ReadLine());

            while (dia < 1 || dia > 31)
            {
                Console.WriteLine("Amove illo como va a tener esos dias mongolo");
                Console.Write("Dime dia:");
                dia = int.Parse(Console.ReadLine());
            }

            Console.Write("Dime mes:");
            mes = int.Parse(Console.ReadLine());

            while (mes < 1 || mes > 12)
            {
                Console.WriteLine("Amove illo como va a ser ese mes mongolo");
                Console.Write("Dime mes:");
                mes = int.Parse(Console.ReadLine());
            }


            Console.Write("Dime año:");
            ano = int.Parse(Console.ReadLine());

            while (ano < 1980 || ano > 2100)
            {
                Console.WriteLine("Amove illo como va a ser ese año mongolo");
                Console.Write("Dime año:");
                ano = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FechaCorrecta(dia,mes,ano));
        }

        static bool FechaCorrecta (int dia, int mes, int ano)
        {

            if (ano % 4 == 0)
            {
                
                while (mes == 2)
                {
                    if (dia <= 29)
                    {
                        return true;
                    }
                    if (dia > 29)
                    {
                        return false;
                    }
                    
                }
                
                while (mes == 1 && mes == 3 && mes == 5 && mes == 7 && mes == 8 && mes == 10 && mes == 12)
                {
                    if (dia <= 31)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }
                    
                }

                while (mes == 4 && mes == 6 && mes == 9 && mes == 11 )
                {
                    if (dia <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }

                return true;





            }
            else
            {
                while (mes == 2)
                {
                    if (dia <= 28)
                    {
                        return true;
                    }
                    if (dia > 29)
                    {
                        return false;
                    }
                }
                return true;

                if (mes == 1 && mes == 3 && mes == 5 && mes == 7 && mes == 8 && mes == 10 && mes == 12)
                {
                    if (dia <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                

                while (mes == 4 && mes == 6 && mes == 9 && mes == 11)
                {
                    if (dia <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
                return false;
            }

            
              
        }
    }
}

