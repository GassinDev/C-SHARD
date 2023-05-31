using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    enum RazaGato 
    {
        Comun, Siames, Persa, Angora, ScottishFold
    }
    class Gato : Animal
    {
        //ATRIBUTOS

        protected RazaGato razaGato;
        protected string microchip;

        //CONSTRUCTOR
        public Gato(string nombre, DateTime fechaNacimiento, double peso, string comentarios, RazaGato razaGato, string microchip) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            this.razaGato = razaGato;
            this.microchip = microchip;
        }

        //PROPIEDADES
        public RazaGato RazaGato
        {
            get { return razaGato; }
        }

        public string Microchip
        {
           get { return microchip; }
        }

        public override string ToString()
        {
            return "Ficha Gato" + "\n" + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Fecha de Nacimiento: " + fechaNacimiento + "\n" +
                   "Peso: " + peso + "\n" +
                   "Comentario: " + comentarios + "\n" +
                   "Raza: " + razaGato + "\n" +
                   "Microchip: " + microchip;
        }


    }
}

