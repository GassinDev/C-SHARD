using System;
using System.IO;

namespace ExplicacionFichero_4_
{
    class Program
    {
        static void Main(string[] args) {
            //{
            //    Directory.CreateDirectory("C:\\Patata");
            //    Directory.Delete("C:\\Patata");
            //    Directory.Move("C:\\Patata", "C:\\Tomate");

            //    if (Directory.Exists("C:\\Tomate"))
            //    {
            //        Console.WriteLine("El archivo está donde tiene que estar");
            //    }

            //if (File.Exists("C:\\Tomate\\patata.txt"))
            //{
            //    Console.WriteLine("El archivo está donde tiene que estar");
            //}

            //File.Move("C:\\Tomate\\patata.txt", "C:\\Tomate\\pimiento.txt");

            //File.Delete("C:\\Tomate\\pimiento.txt");

            //Directory.GetFiles("C:\\Tomate");
            //Directory.GetDirectories("C:\\Tomate");

            string[] ficheros = Directory.GetFiles("C:\\Tomate");

            for(int i = 0; i < ficheros.Length; i++)
            {
                //string nombre1 = ficheros[i];
                //string nombre2 = nombre1.Replace(" ", "_");
                //File.Move(nombre1, nombre2);

                //Console.WriteLine(Path.GetDirectoryName(nombre1));
                //Console.WriteLine(Path.GetFileName(nombre1));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(nombre1));
                //Console.WriteLine(Path.GetExtension(nombre1));

                //string nombre1 = Path.GetFileName(ficheros[i]);

                //if (nombre1.Contains("_"))
                //{
                //    string nombre2 = nombre1.Replace("_", " ");
                //    nombre1 = Path.GetDirectoryName(ficheros[i] + "\\" + nombre1);
                //    nombre2 = Path.GetDirectoryName(ficheros[i] + "\\" + nombre2);
                //    Console.WriteLine("nombre1=" + nombre1);
                //    Console.WriteLine("nombre2=" + nombre2);

                //    File.Move(nombre1, nombre2);

                //}

                //FileInfo f = new FileInfo("C:\\Tomate_2\\autorun.ico");
            }
        }
    }
}
