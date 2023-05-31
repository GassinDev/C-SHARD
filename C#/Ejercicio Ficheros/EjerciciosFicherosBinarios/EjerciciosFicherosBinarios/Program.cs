using System;
using System.Collections.Generic;
using System.IO;

namespace EjerciciosFicherosBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("┌──────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Menú Ficheros de Texto                                       │");
            Console.WriteLine("├───────────────────────────────────┬──────────────────────────┤");
            Console.WriteLine("│ 11- EscribeFichero1_100           │ 19- OrdenaFicheroInt     │");
            Console.WriteLine("│ 12- LeeFicheroInt100              │ 20- SeparaFicheroInt     │");
            Console.WriteLine("│ 13- EscribeFicheroIntAleatorio    │ 21- InvierteFicheroInt   │");
            Console.WriteLine("│ 14- EscribeFicheroIntAleatorioPro │                          │");
            Console.WriteLine("│ 15- LeeFicheroInt                 │                          │");
            Console.WriteLine("│ 16- SumaFicheroInt                │                          │");
            Console.WriteLine("│ 17- LeeFicheroIntLista            │                          │");
            Console.WriteLine("│ 18- EscribeFicheroIntLista        │                          │");
            Console.WriteLine("└───────────────────────────────────┴──────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 11:
                    {
                        EscribeFichero1_100("EscribeFichero1_100.bin");

                    }
                    break;

                case 12:
                    {
                        LeeFicheroInt100("EscribeFichero1_100.bin");

                    }
                    break;

                case 13:
                    {
                        int a;

                        Console.WriteLine("Dime cuantos números te escribo");
                        a = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorio(a, "EscribeFicheroIntAleatorio.bin");

                    }
                    break;

                case 14:
                    {
                        int a, lim_menor, lim_mayor;

                        Console.WriteLine("Dime cuantos números te escribo");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite menor de el rango aleatorio");
                        lim_menor = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite mayor de el rango aleatorio");
                        lim_mayor = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorioPro(a, lim_menor, lim_mayor, "EscribeFicheroIntAleatorioPro.bin");

                    }
                    break;

                case 15:
                    {
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.bin");

                    }
                    break;

                case 16:
                    {
                        int a, lim_menor, lim_mayor;

                        Console.WriteLine("Dime cuantos números te escribo");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite menor de el rango aleatorio");
                        lim_menor = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite mayor de el rango aleatorio");
                        lim_mayor = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorioPro(a, lim_menor, lim_mayor, "EscribeFicheroIntAleatorioPro.bin");
                        Console.WriteLine();
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.bin");
                        Console.WriteLine();
                        Console.WriteLine("La suma es " + SumaFicheroInt("EscribeFicheroIntAleatorioPro.bin"));

                    }
                    break;

                case 17:
                    {
                        int a, lim_menor, lim_mayor;

                        Console.WriteLine("Dime cuantos números te escribo");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite menor de el rango aleatorio");
                        lim_menor = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite mayor de el rango aleatorio");
                        lim_mayor = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorioPro(a, lim_menor, lim_mayor, "EscribeFicheroIntAleatorioPro.bin");
                        Console.WriteLine();

                        List<int> l = LeeFicheroIntLista("EscribeFicheroIntAleatorioPro.bin");
                        EscribeLista(l);
                    }
                    break;

                case 18:
                    {
                        List<int> l = new List<int> { 0, 1, 5, 6, 4 };
                        EscribeFicheroIntLista("EscribeFicheroIntLista.bin", l);
                        LeeFicheroInt("EscribeFicheroIntLista.bin");

                    }
                    break;

                case 19:
                    {
                        List<int> l = new List<int> { 0, 1, 5, 6, 4, 12, 456, 2, 5 };
                        EscribeFicheroIntLista("EscribeFicheroIntLista.bin", l);
                        OrdenaFicheroInt("EscribeFicheroIntLista.bin");
                        LeeFicheroInt("EscribeFicheroIntLista.bin");

                    }
                    break;

                case 20:
                    {
                        int a, lim_menor, lim_mayor;

                        Console.WriteLine("Dime cuantos números te escribo");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite menor de el rango aleatorio");
                        lim_menor = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el límite mayor de el rango aleatorio");
                        lim_mayor = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorioPro(a, lim_menor, lim_mayor, "EscribeFicheroIntAleatorioPro.bin");
                        SeparaFicheroInt("EscribeFicheroIntAleatorioPro.bin");
                        Console.WriteLine("Positivos");
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.binpositivos");
                        Console.WriteLine();
                        Console.WriteLine("Negativos");
                        LeeFicheroInt("EscribeFicheroIntAleatorioPro.binnegativos");

                    }
                    break;

                case 21:
                    {
                        EscribeFichero1_100("EscribeFichero1_100.bin");
                        InvierteFicheroInt("EscribeFichero1_100.bin");
                        LeeFicheroInt("EscribeFichero1_100.bin");
                    }
                    break;
            }



        }



        static void EscribeFichero1_100(string ficherobinario)
        {

            FileStream fs = new FileStream(ficherobinario, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int i = 0;

            for (i = 0; i < 100; i++)
            {
                bw.Write(i + 1);

            }

            bw.Close();
            fs.Close();
        }

        static void LeeFicheroInt100(string ficherobinario)
        {

            FileStream fs = new FileStream(ficherobinario, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int i = 0, s;

            for (i = 0; i < 100; i++)
            {
                s = br.ReadInt32();
                Console.WriteLine(s);


            }

            br.Close();
            fs.Close();
        }

        static void EscribeFicheroIntAleatorio(int a, string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int i = 0;
            Random r = new Random();

            for (i = 0; i < a; i++)
            {
                bw.Write(r.Next(1, 101));

            }

            bw.Close();
            fs.Close();

        }


        static void EscribeFicheroIntAleatorioPro(int a, int lim_menor, int lim_mayor, string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int i = 0;
            Random r = new Random();

            for (i = 0; i < a; i++)
            {
                bw.Write(r.Next(lim_menor, lim_mayor));

            }

            bw.Close();
            fs.Close();
        }


        static void LeeFicheroInt(string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int i = 0, s;

            while (fs.Position < fs.Length)
            {
                s = br.ReadInt32();
                Console.WriteLine(s);

            }

            br.Close();
            fs.Close();

        }

        static int SumaFicheroInt(string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int suma = 0, s;

            while (fs.Position < fs.Length)
            {
                s = br.ReadInt32();
                suma = suma + s;
            }


            br.Close();

            return suma;
        }

        static void EscribeLista(List<int> l)
        {
            Console.Write("< ");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine(">");
        }

        static List<int> LeeFicheroIntLista(string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            List<int> l = new List<int>();

            int s;

            while (fs.Position < fs.Length)
            {
                s = br.ReadInt32();
                l.Add(s);


            }

            br.Close();
            fs.Close();

            return l;

        }

        static void EscribeFicheroIntLista(string ficherobinario, List<int> l)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int i;

            for (i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }

            bw.Close();
            fs.Close();

        }

        static void OrdenaFicheroInt(string ficherobinario)
        {
            List<int> l = LeeFicheroIntLista(ficherobinario);

            l.Sort();

            EscribeFicheroIntLista(ficherobinario, l);

        }

        static void SeparaFicheroInt(string ficherobinario)
        {
            List<int> l = LeeFicheroIntLista(ficherobinario), numpos = new List<int>(), numnega = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    numpos.Add(l[i]);
                }
                else
                {
                    numnega.Add(l[i]);
                }
            }

        }

        static void InvierteFicheroInt(string ficherobinario)
        {
            List<int> l = LeeFicheroIntLista(ficherobinario);
            l.Reverse();
            EscribeFicheroIntLista(ficherobinario, l);
        }
    }
}
