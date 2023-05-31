using System;

namespace EjercicioClasesyObjetos_Animales
{
    class Program
    {
        static ClinicaVeterinaria c = new ClinicaVeterinaria();


        static void Main(string[] args)
        {
            /* Perro p = new Perro("Pepe", new DateTime(2010,12,12),12,"Ta malo", razaPerro:RazaPerro.PastorAleman,"56467557866");
            Console.WriteLine(p);
            Console.WriteLine();
            Gato g = new Gato("Manue", new DateTime(2010, 12, 12), 10, "Ta chungo", razaGato: RazaGato.Angora, "06457557866");
            Console.WriteLine(g);
            Console.WriteLine();
            Pajaro pa = new Pajaro("Felipe", new DateTime(2013, 2, 12), 15, "Ta regu", especiePajaro: EspeciePajaro.Agapornis, true);
            Console.WriteLine(pa);
            Console.WriteLine();
            Reptil r = new Reptil("KOKO", new DateTime(2019, 1, 12), 13, "Ta fatal", especieReptil: EspecieReptil.Iguana, false);
            Console.WriteLine(r); */



            int opcion = -1;


            while (opcion != 0)
            {
                Console.WriteLine("Menu de SrGassin");
                Console.WriteLine();
                Console.WriteLine("1. Añadir Animal");
                Console.WriteLine("2. Cambiar comentario de Animal");
                Console.WriteLine();

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Elije el animal que quieres introducir:");
                            Console.WriteLine();
                            Console.WriteLine("1. Perro");
                            Console.WriteLine("2. Pajaro");
                            Console.WriteLine("3. Gato");
                            Console.WriteLine("4. Reptil");

                            int opcion2;
                            opcion2 = int.Parse(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1: CreadorPerros(); break;
                                case 2: CreadorPajaro(); break;
                                case 3: CreadorGato(); break;
                                case 4: CreadorReptil(); break;
                            }


                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Dime el nombre del animal:");
                            string nombre;
                            nombre = Console.ReadLine();

                            Console.WriteLine("Dime el nuevo comentario: ");
                            string comentario;
                            comentario = Console.ReadLine();

                            c.ModificaComentarioAnimal(nombre, comentario);
                            Console.WriteLine();
                        }

                        break;
                }
            }
            



        }


        private static void CreadorPerros()
        {
            string nombre, fechaNacimiento, microchip, comentarios;
            double peso;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Fecha de Nacimiento: ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Comentario: ");
            comentarios = Console.ReadLine();

            RazaPerro raza;
            int opcionperro;
            Console.Write("Raza (0-5): \n1-SanBernardo 2-Dalmata 3-Husky 4-FoxTerrier 5-PastorAleman");
            opcionperro = int.Parse(Console.ReadLine());
            switch (opcionperro)
            {
                case 1: raza = RazaPerro.SanBernardo; break;
                case 2: raza = RazaPerro.Dalmata; break;
                case 3: raza = RazaPerro.Husky; break;
                case 4: raza = RazaPerro.FoxTerrier; break;
                case 5: raza = RazaPerro.PastorAleman; break;
                default: raza = RazaPerro.PastorAleman; break;
            }

            Console.Write("Microchip: ");
            microchip = Console.ReadLine();

            Perro p = new Perro(nombre, DateTime.Parse(fechaNacimiento), peso, raza, microchip, comentarios);

            c.InsertarAnimal(p);
            Console.WriteLine(p);
            Console.WriteLine("Pulsa 0 para volver al menú");
            Console.ReadLine();
        }

        private static void CreadorPajaro()
        {
            string nombre, fechaNacimiento,comentarios;
            double peso;
            bool cantor;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Fecha de Nacimiento: ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Comentario: ");
            comentarios = Console.ReadLine();

            EspeciePajaro especie;
            int opcionespecie;
            Console.Write("Especie (0-3): \n1-Agapornis 2-Canario 3-Periquito");
            opcionespecie = int.Parse(Console.ReadLine());
            switch (opcionespecie)
            {
                case 1: especie = EspeciePajaro.Agapornis; break;
                case 2: especie = EspeciePajaro.Canario; break;
                case 3: especie = EspeciePajaro.Periquito; break;
                default: especie = EspeciePajaro.Canario; break;
            }

            Console.Write("Cantor: ");
            cantor = bool.Parse(Console.ReadLine());

            Pajaro pa = new Pajaro(nombre, DateTime.Parse(fechaNacimiento), peso, comentarios, especie, cantor);

            c.InsertarAnimal(pa);
            Console.WriteLine(pa);
            Console.WriteLine("Pulsa 0 para volver al menú");
            Console.ReadLine();
        }

        private static void CreadorGato()
        {
            string nombre, fechaNacimiento,microchip, comentarios;
            double peso;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Fecha de Nacimiento: ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Comentario: ");
            comentarios = Console.ReadLine();

            RazaGato raza;
            int opciongato;
            Console.Write("Raza (0-5): \n1-Angora 2-Siames 3-Comun 4-Persa 5-ScottishFold");
            opciongato = int.Parse(Console.ReadLine());
            switch (opciongato)
            {
                case 1: raza = RazaGato.Angora; break;
                case 2: raza = RazaGato.Siames; break;
                case 3: raza = RazaGato.Comun; break;
                case 4: raza = RazaGato.Persa; break;
                case 5: raza = RazaGato.ScottishFold; break;
                default: raza = RazaGato.Persa; break;
            }

            Console.Write("Microchip: ");
            microchip = Console.ReadLine();

            Gato g = new Gato(nombre, DateTime.Parse(fechaNacimiento), peso, comentarios, raza , microchip);

            c.InsertarAnimal(g);
            Console.WriteLine(g);
            Console.WriteLine("Pulsa 0 para volver al menú");
            Console.ReadLine();
        }

        private static void CreadorReptil()
        {
            string nombre, fechaNacimiento, comentarios;
            double peso;
            bool venenoso;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Fecha de Nacimiento: ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Comentario: ");
            comentarios = Console.ReadLine();

            EspecieReptil especie;
            int opcionreptil;
            Console.Write("Especie (0-3): \n1-Iguana 2-Tortuga 3-DragonComodo");
            opcionreptil = int.Parse(Console.ReadLine());
            switch (opcionreptil)
            {
                case 1: especie = EspecieReptil.Iguana; break;
                case 2: especie = EspecieReptil.Tortuga; break;
                case 3: especie = EspecieReptil.DragonDeComodo; break;
                default: especie = EspecieReptil.DragonDeComodo; break;
            }

            Console.Write("Venenoso: ");
            venenoso = bool.Parse(Console.ReadLine());

            Reptil r = new Reptil(nombre, DateTime.Parse(fechaNacimiento), peso, comentarios, especie, venenoso);
            c.InsertarAnimal(r);
            Console.WriteLine(r);
            Console.WriteLine("Pulsa 0 para volver al menú");
            Console.ReadLine();

        }


    }

}
