using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EJERCICIOS_CLASES____COLECCION_DE_VIDEOJUEGOS_
{
    class Coleccion
    {
        //ATRIBUTOS
        private List<Videojuego> ListaJuegos = new List<Videojuego>();

        //PROPIEDADES
        public Coleccion() { }

        //METODOS
        public void InsertaVideojuego(Videojuego v)
        {
            for(int i = 0; i < ListaJuegos.Count; i++)
            {
                ListaJuegos.Add(v);
            }
        }

        public void EliminaVideojuego(int pos)
        {
            ListaJuegos.Remove(ListaJuegos[pos]);
        }

        public void LeeVideojuego(int pos)
        {
            for (int i = 0; i < ListaJuegos.Count; i++)
            {
                Console.WriteLine(ListaJuegos[pos]);
            }
        }

        public void EscribeColeccionFichero(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            int platInt;
            int tipoInt;

            for (int i = 0; i < ListaJuegos.Count; i++)
            {
                sw.WriteLine(ListaJuegos[i].Nombre);
                sw.WriteLine(ListaJuegos[i].Anno);
                platInt = (int)ListaJuegos[i].Plataforma;
                sw.WriteLine(platInt);
                tipoInt = (int)ListaJuegos[i].Tipojuego;
                sw.WriteLine(tipoInt);
                sw.WriteLine(ListaJuegos[i].Valoracion);
            }

            sw.Close();
        }
       
        

        public void LeeColeccionFichero(string fichero)
        {

            StreamReader sr = new StreamReader(fichero);

            string nombre;
            int anno;
            int platInt;
            Plataforma plataforma;
            int tipoInt;
            TipoJuego Tipojuego;
            int valoracion;

            while (!sr.EndOfStream)
            {
                nombre = sr.ReadLine();
                anno = int.Parse(sr.ReadLine());
                platInt = int.Parse(sr.ReadLine());
                plataforma = (Plataforma)platInt;
                tipoInt = int.Parse(sr.ReadLine());
                Tipojuego = (TipoJuego)tipoInt;
                valoracion = int.Parse(sr.ReadLine());

                Videojuego v = new Videojuego(nombre, anno, plataforma, Tipojuego, valoracion);
                ListaJuegos.Add(v);
            }

            sr.Close();

        }

        public string ToString()
        {
            string cadena = "";
            cadena += "Videojuego".PadRight(30) + "Año".PadRight(10) + "Plataforma".PadRight(20) + "Tipo de Juego".PadRight(20) + "Val.\n" + "------------------------------------------------------------------------------------\n";
            for (int i = 0; i < ListaJuegos.Count; i++)
            {
                cadena = cadena + ListaJuegos[i].ToString() + "\n";
            }
            return cadena;
        }

        public string ToStringNum()
        {
            string cadena = "";
            for (int i = 0; i < ListaJuegos.Count; i++)
            {
                cadena += i + 1 + ". " + ListaJuegos[i].Nombre + "\n";
            }
            return cadena;
        }


    }
}
