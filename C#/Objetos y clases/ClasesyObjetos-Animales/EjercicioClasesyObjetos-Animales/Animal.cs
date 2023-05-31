using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    abstract class Animal
    {
        //ATRIBUTOS
        protected string nombre;
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        //CONSTRUCTOR
        public Animal(string nombre, DateTime fechaNacimiento, double peso, string comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.comentarios = comentarios;
        }

        //PROPIEDADES
        public string Nombre
        {
            get 
            { 
                return nombre; 
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
        }

        public double Peso
        {
            get 
            { 
                return peso;
            }
            set 
            {
                if (value > 0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("No puede no pesar nada");
                }
            }
        }

        public string Comentarios
        {
            get { return comentarios; }
            set
            {
                if(value != "")
                {
                    this.comentarios = value;
                }
                else
                {
                    throw new Exception("No puede estar vacío");
                }
            }
        }

        //MÉTODO
        public abstract override string ToString();
    }   
    


    
}
