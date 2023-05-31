using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_ClasesObjetos_ProfesorTribunal
{
    class Profesor
    {
        //ATRIBUTOS
        protected string nombre;
        protected string dni;
        protected string genero;

        //CONSTRUCTOR
        public Profesor (string nombre, string dni, string genero)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.genero = genero;
        }

        //PROPIEDADES

        public string Nombre
        {
            get 
            { 
                return nombre; 
            }

            set 
            { 
                if(value != "")
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception ("El nombre no puede estar vacío");
                }
                
            }
        }

        public string Dni
        {
            get
            { 
                return dni; 
            }

            set 
            {
                if (dni != "")       //---------------------------------------------
                {
                    dni = value;
                }
                else
                {
                    throw new Exception("No es un dni válido");
                }

            }
        }

        public string Genero
        {
            set { genero = value; }
            get 
            {
                if (genero == "hombre" || genero == "Hombre" || genero == "mujer" || genero == "Mujer")
                {
                    return genero;
                }
                else
                {
                    throw new Exception("No es un género");
                }
            }
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\n" 
                +  "Dni: " + dni;
        }
    }
}
