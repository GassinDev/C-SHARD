using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EJERCICIOCLASES_GRUPOYALUMNOS
{
    class Grupo
    {
        //ATRIBUTOS
        private List<Alumno> listaAlumnos = new List<Alumno>();

        //ATRIBUTOS


        //METODOS
        public void InsertaAlumnoLista(Alumno a)
        {

            listaAlumnos.Add(a);
        }

        public void InsertaAlumnoLista(string nombre, int edad, double calificacion)
        {
            Alumno a = new Alumno(nombre, edad, calificacion);
            listaAlumnos.Add(a);
        }

        public override string ToString()
        {

            string s="";

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                s = s + listaAlumnos[i].Nombre + listaAlumnos[i].Edad + listaAlumnos[i].Calificacion + "\n";

            }

            return s;

        }

        public void EscribeFicheroBinario(string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int i;

            bw.Write(listaAlumnos.Count);

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                bw.Write(listaAlumnos[i].Nombre);
                bw.Write(listaAlumnos[i].Edad);
                bw.Write(listaAlumnos[i].Calificacion);
            }

            bw.Close();
            fs.Close();
        }

        public void LeeFicheroBinario(string ficherobinario)
        {
            FileStream fs = new FileStream(ficherobinario, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

           

            string nombre = "";
            int edad;
            double calificacion;

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                
                nombre = br.ReadString();
                edad = br.ReadInt32();
                calificacion = br.ReadDouble();

                Alumno a = new Alumno(nombre, edad, calificacion);

                listaAlumnos.Add(a);
            }

            br.Close();
            fs.Close();
        }

        public void EscribeFicheroTexto(string ficherotexto)
        {
            StreamWriter sw = new StreamWriter(ficherotexto);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].Nombre);
                sw.WriteLine(listaAlumnos[i].Edad);
                sw.WriteLine(listaAlumnos[i].Calificacion);
            }

            sw.Close();
        }

        public void LeeFicheroTexto(string ficherotexto)
        {
            StreamReader sr = new StreamReader(ficherotexto);

            string nombre = "";
            int edad;
            double calificacion;


            while (!sr.EndOfStream)
            {
                nombre = sr.ReadLine();
                edad = int.Parse(sr.ReadLine());
                calificacion = double.Parse(sr.ReadLine());

                Alumno a = new Alumno(nombre, edad, calificacion);

                listaAlumnos.Add(a); 
            }

            sr.Close();
        }

        public void EscribeFicheroCSV(string ficheroCSV)
        {
            StreamWriter sw = new StreamWriter(ficheroCSV);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine($"{listaAlumnos[i].Nombre};{listaAlumnos[i].Edad};{listaAlumnos[i].Calificacion}");
            }

            sw.Close();
        }

        public void LeeFicheroCSV(string ficheroCSV)
        {
            listaAlumnos.Clear();

            StreamReader sr = new StreamReader(ficheroCSV);
            string[] s;

            string nombre = "";
            int edad;
            double calificacion;

            while (!sr.EndOfStream)
            {
                
                s = sr.ReadLine().Split(";");
                nombre = s[0];
                edad = int.Parse(s[1]);
                calificacion = double.Parse(s[2]);

                Alumno a = new Alumno(nombre, edad, calificacion);

                listaAlumnos.Add(a);
            }

            sr.Close();
        }


    }
}
