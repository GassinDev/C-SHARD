using System;
using System.Collections.Generic;
using System.Text;

namespace EJjerciciosObjetosClases_VentaCoches
{
    class Coche
    {
        //ATRIBUTOS
        private string matricula;
        private DateTime fechaMatriculacion;
        private string marca;
        private string modelo;
        private double precio;

        //CONSTRUCTOR
        public Coche(string matricula, DateTime fechaMatriculacion, string marca, string modelo, double precio)
        {
            if (ValidacionMatricula(matricula))
            {
                this.matricula = matricula;
            }
            else
            {
                throw new Exception("No es una matrícula válida");
            }

            if(fechaMatriculacion < DateTime.Now)

            if(marca != null)
            {
                this.marca = marca;
            }
            else
            {
                throw new Exception("No puede estar vacía");
            }

            if(modelo != null)
            {
                this.modelo = modelo;
            }
            else
            {
                throw new Exception("No puede estar vacía");
            }
           
            this.precio = precio;
        }

        //PROPIEDADES
        public string Matricula { get { return matricula; }}
        public DateTime FechaMatriculacion { get { return fechaMatriculacion; } }
        public string Marca { get { return marca; } }   
        public string Modelo { get { return modelo; } }
        public double Precio
        {
            get { return precio; }
            set 
            {
                if(value >= 500)
                {
                    this.precio = value;
                }
                else
                {
                    throw new Exception("No puede ser inferior a 500 euros");
                }
                
            }
        }

    

        //METODO

        public override string ToString()
        {
            return "------Ficha del Coche-------" + "\n" + "\n"
                    + "Matricula: " + matricula + "\n"
                    + "FechaMatriculacion: " + fechaMatriculacion + "\n"
                    + "Marca: " + marca + "\n"
                    + "Modelo: " + modelo + "\n"
                    + "Precio: " + precio;
        }

        public bool ValidacionMatricula(string matricula)
        {
            int contLetras = 0, contDigit = 0;

            for (int i = 0; i < matricula.Length; i++)
            {
               

                if (char.IsDigit(matricula[i]))
                {
                    contDigit++;
                }

                if (char.IsLetter(matricula[i]))
                {
                    contLetras++;
                }

                
                
            }

            if (contDigit == 4 && contLetras == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
