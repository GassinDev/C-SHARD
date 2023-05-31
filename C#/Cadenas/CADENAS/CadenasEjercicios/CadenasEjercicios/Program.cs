using System;

namespace CadenasEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("┌───────────────────────────────────────────────────┐└┘─┬┴┤┤├ ");
            Console.WriteLine("│ Menú Cadenas                                      │");
            Console.WriteLine("├──────────────────────┬────────────────────────────┤");
            Console.WriteLine("│ 1- NumeroEspacios    │ 11- QuitaCaracter          │");
            Console.WriteLine("│ 2- NumeroVocales     │ 12- QuitaAcentos           │");
            Console.WriteLine("│ 3- EsPalindromo      │ 13- InvierteCadena         │");
            Console.WriteLine("│ 4- Contiene          │ 14- VecesCaracter          │");
            Console.WriteLine("│ 5- RepiteCaracter    │ 15- VecesPalabra           │");
            Console.WriteLine("│ 6- QuitaEspacios     │ 16- MayusculasPrimera      │");
            Console.WriteLine("│ 7- QuitaEspaciosTrim │ 17- SustituyePalabra       │");
            Console.WriteLine("│ 8- SustituyeCaracter │ 18- InviertePalabras       │");
            Console.WriteLine("│ 9- CuentaPalabras    │ 19- MarcaSubCadena         │");
            Console.WriteLine("│ 10- EsNumero         │ 20- QuitaEspaciosSobrantes │");
            Console.WriteLine("└──────────────────────┴────────────────────────────┘");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {

                case 1:
                    {
                        string s = " hola que pasa tio ";

                        Console.WriteLine(NumeroEspacios(s));

                    }
                    break;

                case 2:
                    {
                        string s = "hola que pasa tio";

                        Console.WriteLine(NumerosVocales(s));

                    }
                    break;

                case 3:
                    {
                        string s = "dabalearrozalazorraelabad";


                        Console.WriteLine(EsPalindromo(s));

                    }
                    break;

                case 4:
                    {
                        string s = "hola que pasa tio";

                        char letra;

                        Console.WriteLine("Dime la letra");
                        letra = Console.ReadLine()[0];

                        Console.WriteLine(Contiene(s, letra));
                        //Console.WriteLine(Contiene(s[], letra));//



                    }
                    break;

                case 5:
                    {
                        char caracter;
                        int num;

                        Console.WriteLine("Dime el número");
                        num = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime el carácter");
                        caracter = Console.ReadLine()[0];

                        Console.WriteLine(RepiteCaracter(caracter,  num));


                    }
                    break;

                case 6:
                    {
                        string s = " hola que pasa tio ";

                        Console.WriteLine(QuitaEspacios(s));

                        



                    }
                    break;

                case 7:
                    {
                        string s = "         hola que pasa tio                   ";

                        Console.WriteLine("+" + QuitaEspaciosTrim(s) + "+");

                    }
                    break;

                case 8:
                    {
                        string s = " hola que pasa tio ";

                        char caracter;

                        Console.WriteLine("Dime la letra");
                        caracter = Console.ReadLine()[0];

                        char caracter2;

                        Console.WriteLine("Dime la letra");
                        caracter2 = Console.ReadLine()[0];


                        Console.WriteLine(SustituyeCaracter(s, caracter, caracter2));
                        
                    }
                    break;

                case 9:
                    {
                        string s = "    hola   que   pasa tio        ";

                        Console.WriteLine(CuentaPalabras(s));
                        
                    }
                    break;

                case 10:
                    {
                        string s = "023472390e24";

                        Console.WriteLine(EsNumero(s));



                    }
                    break;

                case 11:
                    {
                        string s = "Hola buenas tardes";
                        char caracter;

                        Console.WriteLine("Dime el caracter que quieres quitar");
                        caracter = Console.ReadLine()[0];

                        Console.WriteLine(QuitaCaracter(s, caracter));


                    }
                    break;

                case 12:
                    {
                        string s = "Holá buénas tárdes";

                        Console.WriteLine(QuitaAcentos(s));


                    }
                    break;

                case 13:
                    {
                        string s = "Tu quien ere perro";

                        Console.WriteLine(InvierteCadena(s));

                    }
                    break;

                case 14:
                    {
                        string s = "Perico pin periquito pimpam";

                        char caracter;

                        Console.WriteLine("Dime el caracter:");
                        caracter = Console.ReadLine()[0];

                        Console.WriteLine(VecesCaracter(s, caracter));
                    }
                    break;

                case 15:
                    {
                        string s = "cama camaleón cama";
                        string palabra;

                        Console.WriteLine("Dime la palabra:");
                        palabra = Console.ReadLine();

                        Console.WriteLine(VecesPalabra(s, palabra));

                    }
                    break;

                case 16:
                    {
                        string s = "para ti el regalo";

                        Console.WriteLine(MayusculasPrimera(s));

                    }
                    break;

                case 17:
                    {
                        string s = "peinate el flequillo";
                        string palabraantigua, palabranueva;
                        
                        Console.WriteLine(s);

                        Console.WriteLine("Dime la palabra que quieres cambiar:");
                        palabraantigua = Console.ReadLine();

                        Console.WriteLine("Por cuál pixa?");
                        palabranueva = Console.ReadLine();

                        Console.WriteLine(SustituyePalabra(s, palabraantigua, palabranueva));

                    }
                    break;

                case 18:
                    {
                        string s = "hola buenas tardes";

                        
                        Console.WriteLine(InviertePalabras(s));


                    }
                    break;

                case 19:
                    {
                        string s = "hola buenas tardes";





                    }
                    break;

                case 20:
                    {
                        string s = "hola buenas tardes";





                    }
                    break;




            }
        }

        static int NumeroEspacios (string s)
        {
            int i, cont = 0;
            
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    cont++;
                }
            }
            return cont;


        }


        static int NumerosVocales (string s)
        {
            int i, cont = 0; 

            for(i = 0; i < s.Length; i++)
            {

              if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    cont++;
                }
             
            }


            return cont;
        }


        static bool EsPalindromo (string s)
        {

            int i;

            for (i = 0; i < s.Length; i++)
            {

                if (s[i] != s[s.Length - i - 1])
                {

                    return false;
                }


            }



            return true;

            
        }

        static bool Contiene (string s, char letra)
        {

            int i;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == letra)
                {

                    return true;

                }

            }  
                    return false;
                

          
        } 


        static string RepiteCaracter(char caracter, int num)
        {
            int i;
            string s = "";

            for(i = 0; i < num; i++)
            {

                s = s + caracter;
            }

            return s;

        }

        static string QuitaEspacios (string s)
        {

            int i;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s = s.Remove(i, 1);
                }       
            }


            return s;

        }


        static string QuitaEspaciosTrim (string s)
        {

            int i = 0;

            while (s[i] == ' ')
            {

                s = s.Remove(i, 1);

            }

            while (s[s.Length - 1] == ' ')
            {

                s = s.Remove(s.Length - 1, 1);

            }


            return s;


        }


        static string SustituyeCaracter (string s, char caracter, char caracter2)
        {

            int i;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == caracter)
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, caracter2.ToString());

                }
             
            }

            return s;



        }
        

        static int CuentaPalabras (string s)
        {

            int i, cont = 0;

            s = " " + s;

            for (i = 0; i < s.Length-1; i++)
            {
                if(s[i] == ' ' && s[i+1] != ' ')
                {
                        cont++;
                }
            }

                return cont;
        }

        static bool EsNumero(string s)
        {
            int cont;
            cont = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    cont++;
                }

            }
            if (cont == s.Length)
            {
                return true;
            }
            else
            {
            return false;
            }
        }

        static string QuitaCaracter(string s, char caracter)
        {
            int i;

            for (i = 0; i < s.Length; i++)
            {

                while ( s[i] == caracter)
                {

                    s = s.Remove(i, 1);
                }

            }


            return s;


        }

        static string QuitaAcentos(string s)
        {
            int i, pos;
            string acen = "áÁéÉíÍóÓúÚÜü";
            string sinacen = "aAeEiIoOuUUu";

            for (i = 0; i < s.Length; i++)
            {
                
                if(acen.Contains(s[i]))
                {
                    pos = acen.IndexOf(s[i]);
                    s = s.Remove(i, 1);
                    s = s.Insert(i, sinacen[pos].ToString());

                }
                



            }





            return s;
        }

        static string InvierteCadena(string s)
        {
            int i;
            string s2 = " ";

            for (i = s.Length - 1; i >= 0; i--)
            {
                
                s2 = s2 + s[i];

            }



            return s2;

        }

        static int VecesCaracter(string s, char caracter)
        {
            int i, cont = 0;

            for (i = 0; i < s.Length; i++)
            {

                if (s[i] == caracter)
                {

                    cont++;
                }


            }


            return cont;


        }

        static int VecesPalabra(string s, string palabra)
        {
            int i, cont = 0;

            string[] array = s.Split(" ");

            // ej: "hola que tal"
            // array = {"hola", "que", "tal"}
            
            for(i = 0; i < array.Length; i++)
            {
                if (array[i] == palabra)
                {

                    cont++;
                }


            }


            return cont;

        }

        static string MayusculasPrimera(string s)
        {
            int i;
            char letra;
            s = ' ' + s;

            for (i = 0; i < s.Length-1; i++)
            {

                if (s[i] != ' ' && s[i - 1] == ' ')
                {
                    letra = char.ToUpper(s[i]);

                    s = s.Remove(i, 1);
                    s = s.Insert(i, letra.ToString());

                    

                }


            }
            s = s.Remove(0, 1);

            return s;

        }

        static string SustituyePalabra(string s, string palabraantigua, string palabranueva)
        {
            int i;

            string[] array = s.Split(" ");

            // ej: "hola que tal"
            // array = {"hola", "que", "tal"}

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == palabraantigua)
                {
                    array[i] = palabranueva;
                    
                }
            }

            string s2 = string.Join(" ", array);


            return s2;

        }

        static string InviertePalabras(string s)
        {
            int i;
           

            string[] array = s.Split(' ');

           for (i = 0; i < array.Length; i++)
            {

                array[i] = InvierteCadena(array[i]);

                

            }

            s = string.Join(" ", array);

            return s;


        }

        static string 




    }
 }

