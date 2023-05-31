using System;
using System.IO;

namespace EjerciciosFicheros_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("┌─────────────────────────────────┐");
            Console.WriteLine("│ Menú Listas                     │");
            Console.WriteLine("├─────────────────────────────────┤");
            Console.WriteLine("│ 1- CuantosFicheros              │ ");
            Console.WriteLine("│ 2- CuantosFicherosPro           │ ");
            Console.WriteLine("│ 3- CreaBackup                   │ ");
            Console.WriteLine("│ 4- RenombraMasivo               │ ");
            Console.WriteLine("│ 5- CuentaLineasFicheros         │ ");
            Console.WriteLine("│ 6- FicheroMasGrande             │ ");
            Console.WriteLine("│ 7- ClasificaFicheros            │ ");
            Console.WriteLine("└─────────────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {

                case 1:
                    {
                        string extension = ".txt";
                        Console.WriteLine(CuantosFicheros(extension)); 
                    }
                    break;

                case 2:
                    {
                        string extension = ".txt";
                        string carpeta = "C:\\Users\\Gassín\\Desktop\\Nueva carpeta";
                        Console.WriteLine(CuantosFicherosPro(extension, carpeta));

                    }
                    break;

                case 3:
                    {
                        string fichero = "berenjena.txt";
                        CreaBackup(fichero);
                    }
                    break;

                case 4:
                    {
                        string extension = ".txt";
                        RenombraMasivo(extension);
                    }
                    break;

                case 5:
                    {


                    }
                    break;
            }

            static int CuantosFicheros(string extension)
            {
                int cont = 0;

                string[] ficheros = Directory.GetFiles(".");

                for(int i = 0; i < ficheros.Length; i++)
                {
                    if(Path.GetExtension(ficheros[i]) == extension)
                    {
                        cont++;
                    }

                }

                return cont;
            }

            static int CuantosFicherosPro(string extension, string carpeta)
            {
                int cont = 0;

                string[] ficheros = Directory.GetFiles(carpeta);

                for (int i = 0; i < ficheros.Length; i++)
                {
                    if (Path.GetExtension(ficheros[i]) == extension)
                    {
                        cont++;
                    }

                }

                return cont;
            }

            static void CreaBackup(string fichero)
            {
                string fichero2 = fichero + ".bak";

                while (File.Exists(fichero2))
                {
                    fichero2 = fichero2 + ".bak";

                }
                    File.Copy(fichero, fichero2);

            }

            static void RenombraMasivo(string extension)
            {
                string[] ficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

                for (int i = 0; i < ficheros.Length; i++)
                {
                    string nombre1 = ficheros[i];
                    string nombre2 = nombre1.Replace(extension, ".texto");
                    File.Move(nombre1, nombre2);

                }

            }

            static void CuentaLineasFicheros()
            {
                
            }
        }
    }
}
