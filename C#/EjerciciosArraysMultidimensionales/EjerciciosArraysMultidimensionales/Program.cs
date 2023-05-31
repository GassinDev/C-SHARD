using System;

namespace EjerciciosArraysMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("┌──────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Menú Listas                                          │");
            Console.WriteLine("├─────────────────────────┬────────────────────────────┤");
            Console.WriteLine("│ 1- escribeArray3x3      │ 9-  suma2ArraysBi          │");
            Console.WriteLine("│ 2- rellena3x3           │ 10- copiaArrayBi           │");
            Console.WriteLine("│ 3- RellenaAleatorio3x3  │ 11- copiaArrayBiPro        │");
            Console.WriteLine("│ 4- sumaArray3x3         │ 12- rellenaDiagonal        │");
            Console.WriteLine("│ 5- escribeArrayBi       │ 13- rellenaArrayAjedrez    │");
            Console.WriteLine("│ 6- rellenaAleatorioBi   │ 14- rellenaX               │");
            Console.WriteLine("│ 7- rellenaEnordenBi     │ 15-  rellenaCuadros        │");
            Console.WriteLine("│ 8- sumaArrayBi          │                            │");
            Console.WriteLine("└─────────────────────────┴────────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {

                case 1:
                    {

                        int[,] a = { { 1, 0, 12},
                                          { 1, 8, 72},
                                          { 2, 34, 1} };

                        escribeArray3x3(a);
                    }
                    break;

                case 2:
                    {
                        int[,] a = new int[3, 3];

                        rellena3x3(a);
                        escribeArray3x3(a);

                    }
                    break;


                case 3:
                    {
                        int[,] a = new int[3, 3];

                        RellenaAleatorio3x3(a);
                        escribeArray3x3(a);

                    }
                    break;

                case 4:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);
                        escribeArray3x3(a);
                        Console.WriteLine();
                        Console.WriteLine("La suma es " + SumaArray3x3(a));
                    }
                    break;

                case 5:
                    {

                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];

                        RellenaEnordenBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];

                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 7:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];

                        RellenaEnordenBi(a);
                        EscribeArrayBi(a);

                    }
                    break;

                case 8:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];

                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                        Console.WriteLine(SumaArrayBi(a));
                    }
                    break;

                case 9:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];
                        int[,] b = new int[lado, abajo];
                        int[,] c = new int[lado, abajo];

                        RellenaAleatorioBi(a);
                        RellenaAleatorioBi(b);
                        EscribeArrayBi(a);
                        Console.WriteLine();
                        Console.WriteLine();
                        EscribeArrayBi(b);
                        Console.WriteLine();
                        Console.WriteLine();
                        EscribeArrayBi(c);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Este array bi es la suma de los dos primeros arrays bi");
                        Console.WriteLine();
                        Suma2ArraysBi(a, b, c);
                        EscribeArrayBi(c);


                    }
                    break;

                case 10:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];
                        int[,] b = new int[lado, abajo];

                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                        Console.WriteLine();
                        Console.WriteLine();
                        EscribeArrayBi(b);
                        Console.WriteLine();
                        Console.WriteLine();
                        CopiaArrayBi(a, b);
                        EscribeArrayBi(b);

                    }
                    break;

                case 11:
                    {
                        Console.WriteLine("Dime la dimensión pal lao ");
                        int abajo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la dimensión pa abajo ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, abajo];

                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                        Console.WriteLine();
                        Console.WriteLine();
                        EscribeArrayBi(CopiaArrayBiPro(a));

                        //// int[,] b = CopiaArrayBiPro(a);
                        ////EscribeArrayBi(b);

                    }
                    break;

                case 12:
                    {
                        int[,] a = new int[8, 8];

                        RellenaArrayAjedrez(a);
                        EscribeArrayBi(a);

                    }
                    break;

                case 13:
                    {

                        Console.WriteLine("Dime la dimensión ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, lado];

                        RellenaDiagonal(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 14:
                    {
                        Console.WriteLine("Dime la dimensión ");
                        int lado = int.Parse(Console.ReadLine());



                        int[,] a = new int[lado, lado];

                        RellenaX(a);
                        EscribeArrayBi(a);

                    }
                    break;

                case 15:
                    {
                        Console.WriteLine("Dime la dimensión de un array cuadrado y que sea par ");
                        int lado = int.Parse(Console.ReadLine());

                        int[,] a = new int[lado, lado];

                        while (lado % 2 != 0)
                        {
                            Console.WriteLine("Te he dicho la dimensión de un array cuadrado y que sea par");
                            Console.WriteLine("Dime otra vez la dimensión, pero bien");
                            lado = int.Parse(Console.ReadLine());
                        }

                        RellenaCuadros(a);
                        EscribeArrayBi(a);

                    }
                    break;

            }
        }

        static void escribeArray3x3(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[");

                for (int j = 0; j < 3; j++)
                {

                    Console.Write(a[i, j] + " ");


                }

                Console.Write("]");
                Console.WriteLine();
            }
        }

        static void rellena3x3(int[,] a)
        {
            int n = 1;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {


                    a[i, j] = n;

                    n++;
                }
            }
        }

        static void RellenaAleatorio3x3(int[,] a)
        {
            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    int n = r.Next(1, 100);

                    a[i, j] = n;


                }
            }

        }

        static int SumaArray3x3(int[,] a)
        {
            int suma = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    suma += a[i, j];

                }
            }
            return suma;
        }

        static void EscribeArrayBi(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("[");

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    Console.Write(a[i, j] + " ");


                }

                Console.Write("]");
                Console.WriteLine();
            }

        }

        static void RellenaAleatorioBi(int[,] a)
        {
            Random r = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    int n = r.Next(1, 100);

                    a[i, j] = n;

                }
            }

        }

        static void RellenaEnordenBi(int[,] a)
        {
            int n = 1;

            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {


                    a[i, j] = n;

                    n++;
                }
            }


        }

        static int SumaArrayBi(int[,] a)
        {
            int suma = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    suma += a[i, j];

                }
            }
            return suma;

        }

        static void Suma2ArraysBi(int[,] a, int[,] b, int[,] c)
        {


            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    c[i, j] = a[i, j] + b[i, j];

                }
            }

        }

        static void CopiaArrayBi(int[,] a, int[,] b)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    b[i, j] = a[i, j];

                }
            }

        }

        static int[,] CopiaArrayBiPro(int[,] a)
        {
            int[,] b = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {


                    b[i, j] = a[i, j];

                }
            }
            return b;
        }

        static void RellenaArrayAjedrez(int[,] a)
        {
            int n = 1;

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {


                    a[i, j] = n % 2;
                    n++;

                }
                n++;
            }
        }

        static void RellenaDiagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {

                        if (i < j)
                        {
                            a[i, j] = 2;
                        }
                        else
                        {
                            a[i, j] = 3;
                        }
                    }


                }

            }
        }

        static void RellenaX(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i + j == a.GetLength(0) - 1)
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 2;
                        }
                    }
                }
        }

        static void RellenaCuadros(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)

                for (int j = 0; j < a.GetLength(1); j++)
                {

                    a[i, j] = ((i / (a.GetLength(0) / 2)) * 2 + (j / (a.GetLength(1) / 2))) + 1;

                    //if(j > (a.GetLength(0) / 2) - 1)
                    //{
                    //   if ( j > (a.GetLength(1) / 2) - 1)
                    //    {
                    //        a[i, j] = 4;
                    //    }
                    //    else
                    //    {
                    //        a[i, j] = 3;
                    //    }
                    //}
                    //else
                    //{
                    //    if (j > (a.GetLength(1) / 2) - 1)
                    //    {
                    //        a[i, j] = 2;
                    //    }
                    //    else
                    //    {
                    //        a[i, j] = 1;
                    //    }

                    //}

                }
        }
    }
}


       
    




