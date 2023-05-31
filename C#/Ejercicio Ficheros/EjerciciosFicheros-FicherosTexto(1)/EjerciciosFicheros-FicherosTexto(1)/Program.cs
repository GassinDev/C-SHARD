using System;
using System.Collections.Generic;
using System.IO;

namespace EjerciciosFicheros_FicherosTexto_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Menú Ficheros de Texto                                     │");
            Console.WriteLine("├───────────────────────────────┬────────────────────────────┤");
            Console.WriteLine("│ 1- EscribeFicheroNumRandom10  │ 9- InvierteFicheroTexto    │");
            Console.WriteLine("│ 2- SumaFicheroInt10           │ 10- SeparaPalabrasFichero  │");
            Console.WriteLine("│ 3- EscribeFicheroNumRandom    │                            │");
            Console.WriteLine("│ 4- SumaFicheroInt             │                            │");
            Console.WriteLine("│ 5- EscribeFicheroTexto        │                            │");
            Console.WriteLine("│ 6- LeeFicheroTexto            │                            │");
            Console.WriteLine("│ 7- CopiaFicheroTexto          │                            │");
            Console.WriteLine("│ 8- InvierteLineasFichero      │                            │");
            Console.WriteLine("└───────────────────────────────┴────────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        EscribeFicheroNumRandom10("EscribeFicheroNumRandom10.txt");

                    }
                    break;

                case 2:
                    {
                        Console.WriteLine(SumaFicheroInt10("EscribeFicheroNumRandom10.txt"));

                    }
                    break;

                case 3:
                    {
                        int n;

                        Console.WriteLine("¿ Cuántos números quieres que escriba ?");
                        n = int.Parse(Console.ReadLine());

                        EscribeFicheroNumRandom("EscribeFicheroNumRandom.txt", n);

                    }
                    break;

                case 4:
                    {
                        Console.WriteLine(SumaFicheroInt("EscribeFicheroNumRandom.txt"));

                    }
                    break;

                case 5:
                    {
              
                        EscribeFicheroTexto("EscribeFicheroTexto.txt");

                    }
                    break;

                case 6:
                    {

                        LeeFicheroTexto("EscribeFicheroTexto.txt");
                    }
                    break;

                case 7:
                    {
                        CopiaFicheroTexto("CopiaFicheroTexto.txt", "CopiaFicheroTextoCOPIADO.txt");

                    }
                    break;

                case 8:
                    {
                        InvierteLineasFichero("InvierteLineasFichero.txt", "InvierteLineasFicheroCOPIA.txt");

                    }
                    break;

                case 9:
                    {
                        InvierteFicheroTexto("InvierteFicheroTexto.txt");

                    }
                    break;

                case 10:
                    {
                        SeparaPalabrasFichero("EscribeFicheroTexto.txt","SeparaPalabrasFichero.txt");
                        LeeFicheroTexto("EscribeFicheroTexto.txt");
                    }
                    break;

            }

            static void EscribeFicheroNumRandom10(string fichero)
            {
                int i;

                StreamWriter sw = new StreamWriter(fichero);

                for (i = 0; i < 10; i++)
                {
                    Random r = new Random();

                    sw.WriteLine(r.Next(1, 10));

                }

                sw.Close();

            }

            static string InvierteCadena(string s)
            {
                string resultado = "";

                for (int i = s.Length - 1; i > -1; i--)
                {
                    resultado = resultado + s[i];
                }

                return resultado;
            }

            static int SumaFicheroInt10(string fichero)
            {
                StreamReader sr = new StreamReader(fichero);

                int i, suma = 0;


                for (i = 0; i < 10; i++)
                {
                    suma = suma + int.Parse(sr.ReadLine());
                }

                sr.Close();
                return suma;
            }

            static void EscribeFicheroNumRandom(string fichero2, int n)
            {
                int i;

                StreamWriter sw = new StreamWriter(fichero2);

                for (i = 0; i < n; i++)
                {
                    Random r = new Random();

                    sw.WriteLine(r.Next(1, 10));

                }

                sw.Close();
            }

            static int SumaFicheroInt(string fichero2)
            {
                StreamReader sr = new StreamReader(fichero2);

                int suma = 0;

                while (!sr.EndOfStream)
                {
                    suma = suma + int.Parse(sr.ReadLine());
                }

                sr.Close();

                return suma;

            }

            static void EscribeFicheroTexto(string fichero3)
            {

                string texto;
                texto = Console.ReadLine();

                StreamWriter sw = new StreamWriter(fichero3);

                while(texto != "")
                {
                    sw.WriteLine(texto);
                    texto = Console.ReadLine();
                }
 
                    sw.Close();

            }

            static void LeeFicheroTexto (string fichero3)
            {

                StreamReader sr = new StreamReader(fichero3);

                string linea1;
                while (!sr.EndOfStream)
                {
                    linea1 = sr.ReadLine();
                    Console.WriteLine(linea1);
                }

                sr.Close();
            }

            static void CopiaFicheroTexto (string fichero4, string fichero4copia)
            {
                StreamReader sr = new StreamReader(fichero4);
                StreamReader sw = new StreamReader(fichero4copia);

              
                while (!sr.EndOfStream)
                {
                    

                }

                sw.Close();
                sr.Close();

            }

            static void InvierteLineasFichero(string fichero5, string fichero5COPIA)
            {

                 StreamReader sr = new StreamReader(fichero5);
                 StreamWriter sw = new StreamWriter(fichero5COPIA);

                while (!sr.EndOfStream)
                {
                         sw.WriteLine(InvierteCadena(sr.ReadLine()));
                }

                sr.Close();
                sw.Close();

            }

            static List<string> LineasdeFicheroAListas(string fichero6)
            {
                StreamReader sr = new StreamReader(fichero6);

                List<string> listadelaslineas = new List<string>();

                while (!sr.EndOfStream)
                {
                    listadelaslineas.Add(sr.ReadLine());
                }

                sr.Close();

                return listadelaslineas;

            }
                
            static void InvierteFicheroTexto(string fichero6)
            {
                List<string> listafichero = LineasdeFicheroAListas(fichero6);
                StreamWriter sw = new StreamWriter(fichero6);

                listafichero.Reverse();

                for (int i = 0; i < listafichero.Count; i++)
                {
                    sw.WriteLine(listafichero[i]);
                }

                sw.Close();

            }

            static void SeparaPalabrasFichero(string fichero7, string fichero3)
            {
                StreamReader sr = new StreamReader(fichero3);
                StreamWriter sw = new StreamWriter(fichero7);
                string[] s;

                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine().Split(' ');

                    for (int i = 0; i < s.Length; i++)
                    {
                        sw.WriteLine(s[i]);
                    }
                }
                sw.Close();
                sr.Close();
            }
        }
    }
}
