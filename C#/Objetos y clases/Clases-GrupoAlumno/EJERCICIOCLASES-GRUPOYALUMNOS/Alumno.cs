using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOCLASES_GRUPOYALUMNOS
{
    class Alumno
    {
        //ATRIBUTOS
        private string nombre;
        private int edad;
        private double calificacion;

        //CONSTRUCTORES
        public Alumno(string nombre, int edad, double calificacion)
        {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;

        }

        //PROPIEDADES
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                if (value != "")
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("No puedes no llamarte nada gilipollas");
                }
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                if (edad >= 17 && edad <= 100)
                {
                    this.edad = value;
                }
                else
                {
                    throw new Exception("Esa edad no esta permitida");
                }
            }
        }

        public double Calificacion
        {
            get
            {
                return this.calificacion;
            }

            set
            {

                if (value >= 0 && value <= 10)
                {
                    this.calificacion = value;
                }
                else
                {
                    throw new Exception("No puede se eso pixa");
                }

            }
        }

        //METODO
        public override string ToString()
        {
            return "Nombre: " + this.nombre + ", Edad: " + this.edad + ", Califición: " + this.calificacion;
        }
    }
}
