using System;

namespace Funcionesa3
{
    class Program
    {
        static void Calderilla(double dinero)
        {
            int doseuro=0, uneuro=0, cincuentacent=0, veintecent=0, diezcent=0, cincocent=0, doscent=0, uncent=0;

            dinero = dinero * 100;


            while (dinero>=200)
            {
                dinero = dinero - 200;

                doseuro++;
            }
            while (dinero >= 100)
            {
                dinero = dinero - 100;

                uneuro++;
            }
            while (dinero >= 50)
            {
                dinero = dinero - 50;

                cincuentacent++;
            }
            while (dinero >= 20)
            {
                dinero = dinero - 20;

                veintecent++;
            }
            while (dinero >= 10)
            {
                dinero = dinero - 10;

                diezcent++;
            }
            while (dinero >= 5)
            {
                dinero = dinero - 5;

                cincocent++;
            }
            while (dinero >= 2)
            {
                dinero = dinero - 2;

                doscent++;
            }
            while (dinero >= 1)
            {
                dinero = dinero - 1;

                uncent++;
            }
            Console.WriteLine(doseuro+ " monedas de dos euros  \n"+uneuro+ "monedas de un euro \n " + 
                cincuentacent+ " monedas de cincuenta cent  \n" + veintecent+ "monedas de veinte cent \n " + diezcent
                + "monedas de diez cent  \n" + cincocent+ "monedas de cinco cent \n " + doscent + "monedas de dos cent  \n"
                + uncent+" monedas de un cent");



        }
        static void Main(string[] args)
        {
            // Escribe la función calderilla a la que le pasamos una cantidad de dinero(menor de 5€,
            //puede tener decimales) y nos muestra por pantalla qué monedas debemos usar para
            //dar el cambio(con el menor número posible de monedas).En esta función sí que
            //podéis poner println dentro

            double dinero;

            Console.WriteLine("Dime un número menor que 5");
            dinero = double.Parse(Console.ReadLine());

            while (dinero>5 || dinero<=0)
            {
                Console.WriteLine("Dime El número bien cojones");
                dinero = double.Parse(Console.ReadLine());


            }

           
            Calderilla(dinero);
        }
    }
}
