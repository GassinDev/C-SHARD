using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Menú Listas                                                                      │");
            Console.WriteLine("├──────────────────────┬────────────────────────────┬──────────────────────────────┤");
            Console.WriteLine("│ 1- LeeLista          │ 9- OrdenaListaPalabras     │   17- ModaLista              │");
            Console.WriteLine("│ 2- LeeListaN         │ 10- OrdenaListaPalabras2   │   18- PuntuacionesTrampolin  │");
            Console.WriteLine("│ 3- EscribeLista      │ 11- InsertaArrayEnArrayPro │                              │ ");
            Console.WriteLine("│ 4- EliminaNegativos  │ 12- SorteoBonoloto         │                              │");
            Console.WriteLine("│ 5- ClasificaNumeros  │ 13- EliminaRepetidos       │                              │");
            Console.WriteLine("│ 6- EliminaRepetidos  │ 14- UnionListas            │                              │");
            Console.WriteLine("│ 7- OrdenaListaSeleci │ 15- InterseccionListas     │                              │");
            Console.WriteLine("│ 8- OrdenaListaInserc │ 16- DesordenaLista         │                              │");
            Console.WriteLine("└──────────────────────┴────────────────────────────┴──────────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {

                case 1:
                    {
                        List<int> l = new List<int>();
                        LeeLista(l);
                        EscribeLista(l);

                    }
                    break;

                case 2:
                    {

                        List<int> l = new List<int>();
                        LeeListaN(l);
                        EscribeLista(l);


                    }
                    break;

                case 3:
                    {
                        List<int> l = new List<int> { 1, 2, 3, 4 };
                        EscribeLista(l);


                    }
                    break;

                case 4:
                    {
                        List<int> l = new List<int> { 1, -2, 3, -4, -1, -2 };
                        EscribeLista(l);
                        EliminaNegativos(l);
                        EscribeLista(l);

                    }
                    break;

                case 5:
                    {
                        List<int> l = new List<int> { 1, -2, 3, -4, 2, 3 };
                        List<int> l2 = new List<int>();
                        List<int> l3 = new List<int>();

                        EscribeLista(l);
                        ClasificaNumeros(l, l2, l3);
                        EscribeLista(l2);
                        EscribeLista(l3);

                    }
                    break;

                case 6:
                    {

                        List<int> l = new List<int> { 1, 2, 2, 4, 5, 6, 5 };


                        EscribeLista(l);
                        EliminaRepetidos(l);
                        EscribeLista(l);

                    }
                    break;

                case 7:
                    {

                        List<int> l = new List<int> { 1, 7, 2, 4, 9, 6, 8 };

                        OrdenaListaSeleccion(l);



                    }
                    break;

                case 8:
                    {

                        List<int> l = new List<int> { 1, 7, 2, 4, 9, 6, 8 };

                        OrdenaListaInsercion(l);
                        EscribeLista(l);


                    }
                    break;

                case 9:
                    {
                        List<string> l = new List<string>() {"Hola", "buenas", "Tardes", "como", "estamos"};

                        OrdenaListaPalabras(l);
                        EscribeListaPalabras(l);


                    }
                    break;

                case 10:
                    {
                        List<string> l = new List<string> { "Hola", "que", "pasa", "tio" };
                        EscribeListaString(l);
                        OrdenaListaPalabras2(l);
                        EscribeListaString(l);

                    }
                    break;

                case 11:
                    {
                        Console.Write("Este es el primer array");

                        int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        EscribeArray(a1);

                        Console.WriteLine("Introduce una posicion de ese array y meto todas las posiciones a partir de esa en otro array");
                        int position = int.Parse(Console.ReadLine());

                        EscribeArray(InsertaArrayEnArrayPro(a1, position));
                    }
                    break;
                case 12:
                    {
                        List<int> l = new List<int>();
                        SorteoBonoloto(l);

                        Console.WriteLine("Los participantes son:");
                        EscribeLista(l);

                        Console.WriteLine("Los ganadores son:");
                        EscribeLista(SorteoBonoloto(l));
                    }
                    break;

                case 13:
                    {
                        Console.WriteLine("Dime el tamaño del array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        int[] b = new int[length];
                        Random r = new Random();

                        for (int i = 0; i < a.Length; i++)
                        {
                            int j = r.Next(1, 9);
                            a[i] = j;
                        }

                        Console.Write("Aquí tienes tu array");
                        EscribeArray(a);

                        Console.Write("Este es otro array, pero sin los repetidos: ");
                        EscribeArray(EliminaRepetidos(a, b, length));
                    }
                    break;

                case 14:
                    {
                        List<int> l = new List<int>();
                        List<int> l2 = new List<int>();
                        Random r = new Random();

                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l.Insert(i, j);
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l2.Insert(i, j);
                        }

                        Console.WriteLine("Estas son las dos listas primeras");
                        EscribeLista(l);
                        EscribeLista(l2);

                        Console.WriteLine("Esta es la union de las listas");
                        EscribeLista(UnionListas(l, l2));
                    }
                    break;

                case 15:
                    {
                        List<int> l = new List<int>();
                        List<int> l2 = new List<int>();
                        Random r = new Random();

                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l.Insert(i, j);
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l2.Insert(i, j);
                        }

                        Console.WriteLine("Estas son las dos listas primeras");
                        EscribeLista(l);
                        EscribeLista(l2);

                        Console.WriteLine("Esta es la interseccion:");
                        EscribeLista(InterseccionListas(l, l2));
                    }
                    break;

                case 16:
                    {
                        List<int> l = new List<int> { 1, 2, 3, 4 };

                        Console.Write("Lista en orden inicial: ");
                        EscribeLista(l);
                        EscribeLista(DesordenaLista(l));
                    }
                    break;

                case 17:
                    {

                    }
                    break;

                case 18:
                    {

                    }
                    break;
            }
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

        static void EscribeListaPalabras(List<string> l)
        {
            Console.Write("< ");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine(">");
        }

        static void EscribeListaString(List<string> l)
        {
            Console.Write("< ");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine(">");
        }

        static void LeeLista(List<int> l)
        {
            int i;

            for (i = 0; i < l.Count + 1; i++)
            {
                while (i != -1)
                {

                    i = int.Parse(Console.ReadLine());

                    l.Add(i);

                }
                l.RemoveAt(l.Count - 1);
                break;
            }

        }

        static void EscribeArray(int[] a)
        {
            Console.Write("[ ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("]");
        }

        static void LeeListaN(List<int> l)
        {
            int i;

            int nelem;

            Console.WriteLine("Dime cuantos elementos vas a meter");
            nelem = int.Parse(Console.ReadLine());

            for (i = 0; i < nelem + 1; i++)
            {

                i = int.Parse(Console.ReadLine());

                l.Add(i);

            }

        }

        static void EliminaNegativos(List<int> l)
        {

            int i;

            for (i = 0; i < l.Count; i++)
            {

                if (l[i] < 0)
                {
                    l.RemoveAt(i);
                    i--;
                }

            }

        }

        static void ClasificaNumeros(List<int> l, List<int> l2, List<int> l3)
        {
            int i;

            for (i = 0; i < l.Count; i++)
            {

                if (l[i] >= 0)
                {
                    l2.Add(l[i]);


                }
                else
                {
                    l3.Add(l[i]);
                }

            }

            l2.Sort();
            l3.Sort();

        }

        static void EliminaRepetidos(List<int> l)
        {
            int i;
            List<int> l2 = new List<int>();
            for (i = 0; i < l.Count; i++)
            {

                if (!l2.Contains(l[i]))
                {

                    l2.Add(l[i]);



                }

            }

            l.Clear();
            l.AddRange(l2);
        }

        static void OrdenaListaSeleccion(List<int> l)
        {
            int i, min;

            List<int> resultado = new List<int>();

            for (i = 0; i < l.Count; i++)
            {

                min = l.Min();
                resultado.Add(min);
                l.Remove(min);
                i--;

            }
            EscribeLista(l);
            EscribeLista(resultado);

        }

        static void OrdenaListaInsercion(List<int> l)
        {
            int n;
            bool insertado;
            List<int> resultado = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                n = l[i]; // 20  

                insertado = false;
                // 
                for (int j = 0; j < resultado.Count; j++)
                {
                    if (n < resultado[j])
                    {
                        resultado.Insert(j, n);
                        insertado = true;
                        break;
                    }
                }
                if (insertado == false)
                {
                    resultado.Add(n);
                }
            }
            l.Clear();
            l.AddRange(resultado);

        }

        static void OrdenaListaPalabras (List<string> l)
        {
            
            List<string> resultado = new List<string>();
            l.ToArray();
            while (l.Count > 0)
            {
                string min = l.Min();
                resultado.Add(min);
                l.Remove(min);
            }
                l.Clear();
                l.AddRange(resultado);

            
        }

        static void OrdenaListaPalabras2 (List<string> l)
        {
            List<string> resultado = new List<string>();
            while (l.Count > 0)
            {
                resultado.Add(MinimoDeLista(l));
                l.Remove(MinimoDeLista(l));
            }
            l.AddRange(resultado);

        }

        static string MinimoDeLista(List<string> l)
        {
            string resultado;
            if (l.Count > 0)
            {
                resultado = l[0];
                for (int i = 1; i < l.Count; i++)
                {
                    if (resultado.Length > l[i].Length)
                    {
                        resultado = l[i];
                    }
                }
            }
            else
            {
                resultado = "error";
            }
            return resultado;
        }

        static int[] InsertaArrayEnArrayPro(int[] a1, int position)
        {
            List<int> l = new List<int>();

            l.Add(position);
            for (int i = position; i < a1.Length; i++)
            {
                l.Add(a1[i]);
            }
            int[] a2 = l.ToArray();
            return a2;
        }

        static List<int> SorteoBonoloto(List<int> l)
        {
            for (int i = 0; i <= 49; i++)
            {
                l.Add(i);
            }
            List<int> winners = new List<int>();
            while (winners.Count < 6) // <21 > count = 0
            {
                Random r = new Random(); //Declara numero r aleatorio
                int max = 49; // Declara variable "max = 49"
                int selection = r.Next(0, max); // Entre 1 y 49 (21)
                winners.Add(selection); //añade 21 a la winners
                l.Remove(selection); //quita la posicion 21 (es decir, 21)
                max--;
            }
            return winners;
        }

        static int[] EliminaRepetidos(int[] a, int[] b, int length)
        {
            List<int> l = new List<int>();
           
            for (int i = 0; i < a.Length; i++)
            {
                if (!l.Contains(a[i]))
                {
                    l.Add(a[i]);
                }
            }
            Array.Resize(ref b, l.Count);
            for (int i = 0; i < l.Count; i++)
            {
                b[i] = l[i];
            }
            return b;
        }

        static List<int> UnionListas(List<int> l, List<int> l2)
        {
            List<int> l3 = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                l3.Add(l[i]);
            }
            for (int i = 0; i < l2.Count; i++)
            {
                l3.Add(l2[i]);
            }
            EliminaRepetidos(l3);
            return l3;
        }

        static List<int> InterseccionListas(List<int> l, List<int> l2)
        {
            List<int> l3 = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (l.Contains(l[i]) && l2.Contains(l[i]))
                {
                    l3.Add(l[i]);
                }

            }
            for (int i = 0; i < l2.Count; i++)
            {
                if (l2.Contains(l[i]) && l.Contains(l2[i]))
                {
                    l3.Add(l[i]);
                }
            }
            EliminaRepetidos(l3);
            return l3;
        }

        static List<int> DesordenaLista(List<int> l)
        {
            List<int> l2 = new List<int>(l.Count);
            while (l.Count > 0)
            {
                Random r = new Random();
                int j = r.Next(0, l.Count);
                l2.Add(l[j]);
                l.RemoveAt(j);
            }
            return l2;
        }
    }
}

    

  

