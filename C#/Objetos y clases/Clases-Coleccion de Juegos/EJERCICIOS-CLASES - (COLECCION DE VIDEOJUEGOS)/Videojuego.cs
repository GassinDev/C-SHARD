using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_CLASES____COLECCION_DE_VIDEOJUEGOS_
{
    class Videojuego
    {
        //ATRIBUTOS
        private string nombre;
        private int anno;
        private TipoJuego tipojuego;
        private Plataforma plataforma;
        private int valoracion;

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
                    throw new Exception("Tiene que tener nombre obligatoriamente el juego.");
                }
            }
        }

        public int Anno
        {
            get
            {
                return this.anno;
            }
            set
            {
                if (value >= 1970 && value <= 2100)
                {
                    this.anno = value;
                }
                else
                {
                    throw new Exception("Tiene que estar entre 1970 y 2100 la fecha de salida.");
                }
            }
        }

        public int Valoracion
        {
            get
            {
                return this.valoracion;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.valoracion = value;
                }
                else
                {
                    throw new Exception("Entre 0 y 100 la valoracion.");
                }
            }

        }

        public TipoJuego Tipojuego
        {
            get
            {
                return this.tipojuego;
            }

            set
            {
                this.tipojuego = value;
            }
        }

        public Plataforma Plataforma
        {
            get
            {
                return this.plataforma;
            }

            set
            {
                this.plataforma = value;
            }
        }


        //CONSTRUCTORES
        public Videojuego(string nombre, int anno, Plataforma plataforma, TipoJuego tipojuego, int valoracion)
        {
            Nombre = nombre;
            Anno = anno;
            Valoracion = valoracion;
            
        }

        //METODOS
        public override string ToString()
        {
            return "Nombre: " + nombre + ", Año: " + anno + ", Plataforma: " + plataforma + ", Tipo de Juego: " + tipojuego + ", Valoración: " + valoracion + ".";
        }


    }
}










