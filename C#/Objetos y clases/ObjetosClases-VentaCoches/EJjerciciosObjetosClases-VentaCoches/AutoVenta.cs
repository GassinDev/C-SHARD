using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EJjerciciosObjetosClases_VentaCoches
{
    class AutoVenta
    {
        //ATRIBUTOS
        private List<Coche> listaCoches;

        //CONSTRUCTOR
        public AutoVenta()
        {
            listaCoches = new List<Coche>();
        }
        //PROPIEDADES

        //METODOS
        public void CargaCSV(string ficheroCSV)
        {
            StreamReader sr = new StreamReader(ficheroCSV);
            AutoVenta av = new AutoVenta();

            string[] datos;
            string matricula, marca, modelo;
            double precio;
            DateTime f;
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                datos = sr.ReadLine().Split(';');
                matricula = datos[0];
                marca = datos[1];
                modelo = datos[2];
                f = DateTime.Parse(datos[3]);
                precio = double.Parse(datos[4]);
                Coche c = new Coche(matricula, f, marca, modelo, precio);
                listaCoches.Add(c);
            }
            sr.Close();
        }

        public void GuardaCSV(string ficheroCSV)
        {
            StreamWriter sw = new StreamWriter(ficheroCSV);
            sw.WriteLine($"Matricula Marca Modelo fechaMatriculación Precio");
            for (int i = 0; i < listaCoches.Count; i++)
            {
                sw.WriteLine(listaCoches[i]);
            }
            sw.Close();
        }

        public void InsertaCoche(Coche c)
        {
            listaCoches.Add(c);
        }

        public Coche BuscaCoche(string matricula)
        {
            Coche resultado;
            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaCoches[i].Matricula == matricula)
                {
                    resultado = listaCoches[i];
                    return resultado;
                }
            }
            return listaCoches[0];
        }

        public string ImprimeListado()
        {
            string sc = $"{"Matricula".PadRight(15)}{"Marca".PadRight(15)}{"Modelo".PadRight(15)}{"Fecha matr.".PadRight(15)}{"Precio".PadRight(15)}";
            for (int i = 0; i < listaCoches.Count; i++)
            {
                string añade = $"\n{listaCoches[i].Matricula.PadRight(12)}{listaCoches[i].Marca.PadRight(12)}{listaCoches[i].Modelo.PadRight(12)}{listaCoches[i].FechaMatriculacion.ToShortDateString().ToString().PadRight(12)}{listaCoches[i].Precio.ToString().PadRight(12)}";
                sc = sc + añade;
            }
            return sc;
        }


    }
}
