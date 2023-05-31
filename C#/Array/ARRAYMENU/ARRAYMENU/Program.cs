using System;

namespace ARRAYMENU
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Menú                                                                                               │");
            Console.WriteLine("├──────────────────┬────────────────────────┬─────────────────────────┬──────────────────────────────┤ ");
            Console.WriteLine("│ 1- EscribeArray5 │ 11- RellenaEnOrden     │ 21- CopiaArray          │ 31- ConcatenaArraysPro                           "); 
            Console.WriteLine("│ 2- EscribeArray  │ 12- RellenaEnOrdenDesc │ 22- CopiaArrayInvertido │ 32-                           ");
            Console.WriteLine("│ 3- LeeArray5     │ 13- RellenaAleatorio   │ 23- SumaArrays          │ 33-                             │");
            Console.WriteLine("│ 4- LeeArray      │ 14- EstaOrdenado       │ 24- RMDArray            │ 34-                             │");
            Console.WriteLine("│ 5- PonCeros5     │ 15- NumeroImpares      │ 25- InvierteArray       │ 35-                             │");
            Console.WriteLine("│ 6- PonCero       │ 16- MinArray           │ 26- ComparaArrays       │ 36-                             │");
            Console.WriteLine("│ 7- SumaArray5    │ 17- MaxArray           │ 27- PonNotasArray       │ 37-                             │");
            Console.WriteLine("│ 8- SumaArray     │ 18- NumeroAprobados    │ 28- ConcatenaArrays55   │ 38-                             │");
            Console.WriteLine("│ 9- MediaArray5   │ 19- PorEncimaDe        │ 29- ConcatenaArrays     │ 39-                             │");
            Console.WriteLine("│ 10- MediaArray   │ 20- CuantosCeros       │ 30- Contiene            │ 40-                             │");
            Console.WriteLine("│ 0- Salir         │                        │                         │                              │");
            Console.WriteLine("└──────────────────┴────────────────────────┴─────────────────────────┴──────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("Elije una opción:");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 22, 123, 54, 2, -3 };
                        EscribeArray5(a);
                    }
                    break;

                case 2:
                    {
                        int[] a = { 26, 1245, 3, 235, -434, 354, 86, 285 };
                        EscribeArray(a);
                    }
                    break;

                case 3:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);
                        EscribeArray5(a);
                    }
                    break;

                case 4:
                    {
                        int[] a = new int[6];
                        LeeArray(a);
                        EscribeArray(a);

                    }
                    break;

                case 5:
                    {
                        int[] a = { 26, 1245, 3, 235, -434 };
                        PonCeros5(a);
                        EscribeArray5(a);

                    }
                    break;

                case 6:
                    {
                        int[] a = new int[8];
                        PonCero(a);
                        EscribeArray(a);

                    }
                    break;

                case 7:
                    {
                        int[] a = { 20, 120, 3, 235, 89, 56, 49 };
                        Console.WriteLine(SumaArray5(a));

                    }
                    break;

                case 8:
                    {
                        int[] a = { 20, 120, 3, 235, 89, 56, 49 };
                        Console.WriteLine(SumaArray(a));

                    }
                    break;

                case 9:
                    {
                        int[] a = { 42, 54, 5, 75, 5 };
                        Console.WriteLine(MediaArray5(a));
                    }
                    break;

                case 10:
                    {
                        int[] a = { 42, 54, 5, 75, 5, 8, 29 };
                        Console.WriteLine(MediaArray(a));

                    }
                    break;

                case 11:
                    {
                        int[] a = new int[7];
                        RellenaEnOrden(a);
                        EscribeArray(a);

                    }
                    break;

                case 12:
                    {
                        int[] a = new int[8];
                        RellenaEnOrdenDesc(a);
                        EscribeArray(a);

                    }
                    break;

                case 13:
                    {
                        int[] a = new int[8];
                        RellenaAleatorio(a);
                        EscribeArray(a);

                    }
                    break;

                case 14:
                    {
                        int[] a = { 1, 4, 7, 40 };
                        Console.WriteLine(EstaOrdenado(a));

                    }
                    break;

                case 15:
                    {
                        int[] a = { 3, 4, 1, 4, 9 };
                        Console.WriteLine(NumeroImpares(a));

                    }
                    break;

                case 16:
                    {
                        int[] a = { 3, 4, 1, 4, 9 };
                        Console.WriteLine(MinArray(a));

                    }
                    break;

                case 17:
                    {
                        int[] a = { 3, 4, 15, 4, 9 };
                        Console.WriteLine(MaxArray(a));
                    }
                    break;

                case 18:
                    {
                        int[] a = { 5, 3, 2, 10, 4, 7, 5, 12 };
                        Console.WriteLine(NumeroAprobados(a));
                    }
                    break;

                case 19:
                    {
                        int[] a = { 5, 3, 2, 10, 4, 7, 5, 12 };
                        Console.WriteLine(PorEncimaDe(a));

                    }
                    break;

                case 20:
                    {
                        int[] a = { 5, 3, 2, 0, 4, 7, 0, 12 };
                        Console.WriteLine(CuantosCeros(a));

                    }
                    break;

                case 21:
                    {
                        int[] a = { 5, 3, 2, 0, 4, 7, 0, 12 };
                        int[] b = { 2, 5, 1, 6, 8, 3, 1, 5 };
                        EscribeArray(a);
                        EscribeArray(b);
                        CopiaArray(a, b);
                        EscribeArray(b);
                    }
                    break;

                case 22:
                    {
                        int[] a = { 5, 3, 2, 0, 4, 7, 0, 12 };
                        int[] b = { 2, 5, 1, 6, 8, 3, 1, 5 };
                        EscribeArray(a);
                        EscribeArray(b);
                        CopiaArrayInvertido(a, b);
                        EscribeArray(b);

                    }
                    break;

                case 23:
                    {
                        int[] a = { 5, 3, 2 };
                        int[] b = { 2, 5, 1 };
                        int[] c = new int[3];
                        EscribeArray(a);
                        EscribeArray(b);
                        SumaArrays(a, b, c);
                        EscribeArray(c);

                    }
                    break;

                case 24:
                    {
                        int[] a = { 5, 3, 2 };
                        int[] b = { 2, 5, 1 };
                        int[] c = new int[a.Length];
                        EscribeArray(a);
                        EscribeArray(b);

                        RestaArrays(a, b, c);
                        Console.Write("Resta ----> ");
                        EscribeArray(c);

                        MultiplicaArrays(a, b, c);
                        Console.Write("Multiplica ----> ");
                        EscribeArray(c);

                        DivideArrays(a, b, c);
                        Console.Write("Divide ----> ");
                        EscribeArray(c);

                    }
                    break;

                case 25:
                    {
                        int[] a = { 1, 2, 3, 4 };
                        InvierteArray(a);
                        EscribeArray(a);


                    }
                    break;

                case 26:
                    {
                        int[] a = { 1, 2, 3, 4 };
                        int[] b = { 5, 9, 87, 8 };
                        Console.WriteLine(ComparaArrays(a, b));
                    }
                    break;

                case 27:
                    {
                        double[] a = { 1, 7.6, 3.4, 5 };
                        bool[] b = new bool[a.Length];
                        PonNotasArray(a, b);



                    }
                    break;

                case 28:
                    {
                        int[] a = { 1, 2, 3, 4, 6 };
                        int[] b = { 5, 9, 87, 8, 9 };
                        int[] c = new int[10];

                        EscribeArray(a);
                        EscribeArray(b);
                        ConcatenaArrays55(a, b, c);
                        EscribeArray(c);

                    }
                    break;

                case 29:
                    {
                        int[] a = { 1, 2, 3, 4, 6 };
                        int[] b = { 5, 9, 87, 8, 9, 5, 7 };
                        int[] c = new int[a.Length + b.Length];

                        EscribeArray(a);
                        EscribeArray(b);
                        ConcatenaArrays(a, b, c);
                        EscribeArray(c);

                    }
                    break;

                case 30:
                    {
                        int[] a = { 1, 2, 3, 4, 6 };
                        EscribeArray(a);
                        Console.Write(Contiene(a));



                    }
                    break;

                case 31:
                    {
                        int[] a = { 1, 2, 3, 4, 6 };
                        int[] b = { 5, 9, 87, 8, 9, 5, 7 };
                        int[] c;
                        EscribeArray(a);
                        EscribeArray(b);
                        c = ConcatenaArraysPro(a, b);
                        EscribeArray(c);


                    }
                    break;

                case 32:
                    {
                        int[] a = { 1, 2, 3, 4, 6 };
                        int[] b;
                        EscribeArray(a);
                        b = CopiaArrayPro(a);
                        EscribeArray(b);



                    }
                    break;

                case 33:
                    {

                        int[] a = { 1, 2, 3, 4, 6 };
                        EscribeArray(a);

                        int num, pos;

                        Console.WriteLine("Dime el número");
                        num = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la posición");
                        pos = int.Parse(Console.ReadLine());

                        InsertaEnArray(ref a, num, pos);
                        EscribeArray(a);


                    }
                    break;

                case 34:
                    {
                        int[] a = { 1, 7, 3, 77, 6 };
                        EscribeArray(a);

                        int pos;

                        Console.WriteLine("Dime la posición");
                        pos = int.Parse(Console.ReadLine());

                        BorraDeArray(ref a, pos);
                        EscribeArray(a);

                    }
                    break;

                case 35:
                    {
                        int[] a = { 1, 7, 3, 77, 7 };
                        EscribeArray(a);

                        int num;

                        Console.WriteLine("Dime el número");
                        num = int.Parse(Console.ReadLine());

                        Elimina1ElementoArray(ref a, num);
                        EscribeArray(a);

                    }
                    break;


                case 36:
                    {
                        int[] a = { 1, 7, 3, 77, 7 };
                        EscribeArray(a);

                        int num;

                        Console.WriteLine("Dime el número");
                        num = int.Parse(Console.ReadLine());

                        EliminaElementosArray(ref a, num);
                        EscribeArray(a);


                    }
                    break;

                case 37:
                    {







                    }
                    break;










            }
        }


        static void EscribeArray5(int[] a)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < 5; i++)
            {
                Console.Write(a[i]);
                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }



        static void EscribeArray(int[] a)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static void LeeArray5(int[] a)
        {
            Console.WriteLine("Dime el primer número");
            a[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número");
            a[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercero número");
            a[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el cuarto número");
            a[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el quinto número");
            a[4] = int.Parse(Console.ReadLine());

        }

        static void LeeArray(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Dime los números");
                a[i] = int.Parse(Console.ReadLine());

            }

        }

        static void PonCeros5(int[] a)
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                a[i] = 0;
            }


        }

        static void PonCero(int[] a)
        {

            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }

        }

        static int SumaArray5(int[] a)
        {
            int i, suma = 0;

            for (i = 0; i < 5; i++)
            {

                suma = suma + a[i];

            }

            return suma;

        }

        static int SumaArray(int[] a)
        {
            int i, suma = 0;

            for (i = 0; i < a.Length; i++)
            {

                suma = suma + a[i];

            }

            return suma;

        }

        static double MediaArray5(int[] a)
        {
            int i;
            double media = 0;


            media = SumaArray5(a) / 5.0;

            return media;
        }


        static double MediaArray(int[] a)
        {
            int i;
            double media = 0, divisor;

            divisor = a.Length / 1.0;


            media = SumaArray(a) / divisor;

            return media;
        }


        static void RellenaEnOrden(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;

            }
        }

        static void RellenaEnOrdenDesc(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = a.Length - i;

            }

        }

        static void RellenaAleatorio(int[] a)
        {
            int i;
            Random r = new Random();

            for (i = 0; i < a.Length; i++)
            {

                a[i] = (r.Next(1, 10));

            }


        }

        static bool EstaOrdenado(int[] a)
        {
            int i = 0, menor = int.MinValue;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > menor)
                {
                    menor = a[i];

                }
                else
                {
                    return false;
                }


            }

            return true;

        }

        static int NumeroImpares(int[] a)
        {
            int i, impar = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    impar++;
                }

            }

            return impar;

        }

        static int MinArray(int[] a)
        {
            int i, num = int.MaxValue;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < num)
                {
                    num = a[i];

                }

            }

            return num;
        }

        static int MaxArray(int[] a)
        {
            int i, num = int.MinValue;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > num)
                {
                    num = a[i];

                }

            }

            return num;
        }

        static int NumeroAprobados(int[] a)
        {
            int i, aprobado = 0;


            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5 && a[i] <= 10)
                {
                    aprobado++;

                }

            }

            return aprobado;

        }

        static int PorEncimaDe(int[] a)
        {
            int i, limite, cont = 0;

            Console.WriteLine("Dime el límite:");
            limite = int.Parse(Console.ReadLine());


            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= limite)
                {
                    cont++;

                }

            }

            return cont;

        }

        static int CuantosCeros(int[] a)
        {
            int i, cont = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    cont++;

                }

            }

            return cont;


        }

        static void CopiaArray(int[] a, int[] b)
        {
            int i;
            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen el mismo tamaño.");
            }
        }


        static void CopiaArrayInvertido(int[] a, int[] b)
        {
            int i;
           
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[a.Length - i - 1];
                }
        }

        static void SumaArrays(int[] a, int[] b, int[] c)
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = b[i] + a[i];
                }
            }

        }

        static void RestaArrays(int[] a, int[] b, int[] c)
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] - b[i];
                }
            }


        }

        static void MultiplicaArrays(int[] a, int[] b, int[] c)
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = b[i] * a[i];
                }
            }


        }

        static void DivideArrays(int[] a, int[] b, int[] c)
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] / b[i];
                }
            }


        }

        static void InvierteArray(int[] a)
        {
            int[] b = new int[a.Length];

            CopiaArrayInvertido(a, b);
            CopiaArray(b, a);


            //int i, j, temp;

            //j = a.Length - 1;

            //i = 0;

            //while (i < j)
            //{

            //    temp = a[i];
            //    a[i] = a[j];
            //    a[j] = temp;
            //    i++;
            //    j++;
            //}//


        }

        static bool ComparaArrays(int[] a, int[] b)
        {
            if (a.Length == b.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void PonNotasArray(double[] a, bool[] b)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5 && a[i] <= 10)
                {

                    b[i] = true;
                }
                else
                {
                    b[i] = false;
                }


            }


        }

        static void ConcatenaArrays55(int[] a, int[] b, int[] c)
        {
            int i;


            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];


            }

            for (i = 0; i < b.Length; i++)
            {

                c[i + 5] = b[i];


            }




        }

        static void ConcatenaArrays(int[] a, int[] b, int[] c)
        {
            int i, j;


            j = 0;
            for (i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }

            for (i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }

        }

        static bool Contiene(int[] a)
        {
            int i, e;

            Console.WriteLine("Dime un número");
            e = int.Parse(Console.ReadLine());


            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == e)
                {


                    return true;




                }




            }

            return false;
        }

        static int[] ConcatenaArraysPro(int[] a, int[] b)
        {

            int i, j;

            int[] c = new int[a.Length + b.Length];


            j = 0;
            for (i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }

            for (i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }

            return c;
        }

        static int[] CopiaArrayPro(int[] a)
        {
            int i;

            int[] b = new int[a.Length];


            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }

            return b;
        }

        static void InsertaEnArray(ref int[] a, int num, int pos)
        {
            int i, tamaño = a.Length + 1;

            Array.Resize(ref a, tamaño);

            for (i = a.Length - 1; i > pos - 1; i--)
            {

                a[i] = a[i - 1];
            }

            a[pos - 1] = num;

        }

        static void BorraDeArray(ref int[] a, int pos)
        {

            int i;

            for (i = pos; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];

        
            }

            Array.Resize(ref a, a.Length - 1);
             
        }

        static void Elimina1ElementoArray(ref int[] a, int num)
        {

            int i;



            for (i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == num)
                {
                    BorraDeArray(ref a, i);
                    

                    break;


                }
            }

        }

        static void EliminaElementosArray(ref int[] a, int num)
        {
            int i, tamaño = a.Length;

            Array.Resize(ref a, tamaño);


            for (i = tamaño - 1; i > a[0] - 1; i--)
            {
                if (a[i] == num)
                {

                    a[i] = a[i] - num;




                }
            }
        }


       
    }
}


