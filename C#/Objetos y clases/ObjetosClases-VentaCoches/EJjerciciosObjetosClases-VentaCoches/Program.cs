using System;

namespace EJjerciciosObjetosClases_VentaCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime n = new DateTime(12/11/2002);
            //Coche c = new Coche("4637LGG",n , "Seat","Pollanda",600);
            //Console.WriteLine(c);

            AutoVenta av = new AutoVenta();
            av.CargaCSV("Coches.csv");

            Console.WriteLine("Eligue que quieres hacer:");
            Console.WriteLine();
            Console.WriteLine("1. BuscaCoches");
            Console.WriteLine("2. Imprimir Listado");
            Console.WriteLine("3. Inserta Ccoche");

            int opcion;
            opcion = int.Parse(Console.ReadLine());

            while(opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Introduce la matricula del coche que deseas buscar");

                            string matriculabuscada;
                            matriculabuscada = Console.ReadLine();

                            Console.WriteLine(av.BuscaCoche(matriculabuscada));

                        }break;

                    case 2:
                        {
                            Console.WriteLine(av.ImprimeListado());
                            Console.WriteLine();
                            Console.WriteLine("Parar con cualquier tecla");
                            opcion = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Dime la matricula de su nuevo coche: ");

                            string matriculanueva;
                            matriculanueva = Console.ReadLine();

                            Console.WriteLine("Dime la fecha de matriculacion, debe ser un año anterior al actual");

                            DateTime dt = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Dime la marca");

                            string marcanueva;
                            marcanueva = Console.ReadLine();

                            Console.WriteLine("Dime el modelo");

                            string modelonuevo;
                            modelonuevo = Console.ReadLine();

                            Console.WriteLine("Dime por último el precio del coche (debe ser superior a 500€)");

                            double precionuevo;
                            precionuevo = double.Parse(Console.ReadLine());

                            Coche c = new Coche(matriculanueva, dt, marcanueva, modelonuevo, precionuevo);
                            av.InsertaCoche(c);

                        }
                        break;
                }
            }
        }
    }
}
