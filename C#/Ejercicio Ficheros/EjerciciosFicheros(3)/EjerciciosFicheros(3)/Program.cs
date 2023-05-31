using System;
using System.Collections.Generic;
using System.IO;

namespace EjerciciosFicheros_3_
{
    class Program
    {
        public class FichaAlumno
        {
            public string nombre;
            public int edad;
            public double calificacion;

        }



        static void Main(string[] args)
        {
            List<FichaAlumno> listaAlumnos = new List<FichaAlumno>();
            int opcion = -1;

            while (opcion != 0)
            {

                Console.WriteLine("┌─────────────────────────────────┐");
                Console.WriteLine("│ Menú Listas                     │");
                Console.WriteLine("├─────────────────────────────────┤");
                Console.WriteLine("│ 1- LeeAlumnoLista               │ ");
                Console.WriteLine("│ 2- ImprimeListaAlumnos          │ ");
                Console.WriteLine("│ 3- EscribeFicheroAlumnosBinario │ ");
                Console.WriteLine("│ 4- LeeFicheroAlumnosBinario     │ ");
                Console.WriteLine("│ 5- EscribeFicheroAlumnosTexto   │ ");
                Console.WriteLine("│ 6- LeeFicheroAlumnosTexto       │ ");
                Console.WriteLine("│ 7- EscribeFicheroAlumnosCSV     │ ");
                Console.WriteLine("│ 8- LeeFicheroAlumnosCSV         │   ");
                Console.WriteLine("└─────────────────────────────────┘");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1:
                        {
                            LeeAlumnoLista(listaAlumnos);

                        }
                        break;

                    case 2:
                        {

                            ImprimeListaAlumnos(listaAlumnos);

                        }
                        break;

                    case 3:
                        {

                            EscribeFicheroAlumnosBinario(listaAlumnos, "EscribeFicheroAlumnosBinario.bin");

                        }
                        break;

                    case 4:
                        {

                            LeeFicheroAlumnosBinario(listaAlumnos, "EscribeFicheroAlumnosBinario.bin");

                        }
                        break;
                          
                        {
                            EscribeFicheroAlumnosTexto(listaAlumnos, "FicheroAlumnosTexto");

                        }
                        break;

                    case 6:
                        {
                            LeeFicheroAlumnosTexto(listaAlumnos, "FicheroAlumnosTexto");

                        }
                        break;

                    case 7:
                        {
                            EscribeFicheroAlumnosCSV(listaAlumnos, "FicheroCSV");

                        }
                        break;

                    case 8:
                        {
                            LeeFicheroAlumnosCSV(listaAlumnos, "FicheroCSV");
                        }
                        break;

                }
            }




            static void LeeAlumnoLista(List<FichaAlumno> listaAlumnos)
            {
                string nombre;
                int edad;
                double calificacion;

                Console.WriteLine("Dime el nombre del alumno");
                nombre = Console.ReadLine();

                Console.WriteLine("Dime la edad");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Dime la nota que ha sacado");
                calificacion = double.Parse(Console.ReadLine());

                FichaAlumno fa = new FichaAlumno();

                fa.nombre = nombre;
                fa.edad = edad;
                fa.calificacion = calificacion;


                listaAlumnos.Add(fa);

            }

            static void ImprimeListaAlumnos(List<FichaAlumno> listaAlumnos)
            {


                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nombre: " + listaAlumnos[i].nombre);
                    Console.WriteLine("Edad: " + listaAlumnos[i].edad);
                    Console.WriteLine("Calificacion: " + listaAlumnos[i].calificacion);
                    Console.WriteLine();
                }
            }

            static void EscribeFicheroAlumnosBinario(List<FichaAlumno> listaAlumnos, string ficherobinario)
            {
                FileStream fs = new FileStream(ficherobinario, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                int i;

                FichaAlumno fa = new FichaAlumno();

                int a = 0;

                a = listaAlumnos.Count;

                bw.Write(a);

                for (i = 0; i < listaAlumnos.Count; i++)
                {
                    bw.Write(listaAlumnos[i].nombre);
                    bw.Write(listaAlumnos[i].edad);
                    bw.Write(listaAlumnos[i].calificacion);
                }

                bw.Close();
                fs.Close();
            }


            static void LeeFicheroAlumnosBinario(List<FichaAlumno> listaAlumnos, string ficherobinario)
            {
                FileStream fs = new FileStream(ficherobinario, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);


                while (fs.Position < fs.Length)
                {
                    FichaAlumno fa = new FichaAlumno();
                    fa.nombre = br.ReadString();
                    fa.edad = br.ReadInt32();
                    fa.calificacion = br.ReadDouble();

                    listaAlumnos.Add(fa);

                }
                br.Close();
                fs.Close();
            }



            static void EscribeFicheroAlumnosTexto(List<FichaAlumno> listaAlumnos, string fichero)
            {

                StreamWriter sw = new StreamWriter("prueba.txt");

                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    sw.WriteLine(listaAlumnos[i].nombre);
                    sw.WriteLine(listaAlumnos[i].edad);
                    sw.WriteLine(listaAlumnos[i].calificacion);
                }
                sw.Close();
            }


            static void LeeFicheroAlumnosTexto(List<FichaAlumno> listaAlumnos, string fichero)
            {

                StreamReader sr = new StreamReader(fichero);
               
                while (!sr.EndOfStream)
                {
                    FichaAlumno fa = new FichaAlumno();

                    fa.nombre = sr.ReadLine();
                    fa.edad = int.Parse(sr.ReadLine());
                    fa.calificacion = double.Parse(sr.ReadLine());

                    listaAlumnos.Add(fa);

                }
                
                sr.Close();

            }

            static void EscribeFicheroAlumnosCSV(List<FichaAlumno> l, String fichero)
            {
                // abrir el fichero
                StreamWriter sw = new StreamWriter(fichero);
                // escribrir cosas

                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].nombre + ";");
                    sw.WriteLine(l[i].edad + ";");
                    sw.WriteLine(l[i].calificacion + ";");

                }

                // cerrar cosas
                sw.Close();

            }

            static void LeeFicheroAlumnosCSV(List<FichaAlumno> l, String fichero)
            {
                StreamReader sr = new StreamReader("prueba.txt");
                // para leer


                while (!sr.EndOfStream)
                {
                    FichaAlumno fichaAlumno = new FichaAlumno();
                    string linea1 = sr.ReadLine();

                    string[] subs = linea1.Split(';');
                    fichaAlumno.nombre = subs[0];
                    fichaAlumno.edad = int.Parse(subs[1]);
                    fichaAlumno.calificacion = double.Parse(subs[2]);
                    l.Add(fichaAlumno);

                }
                sr.Close();

            }
        }
    }
}
