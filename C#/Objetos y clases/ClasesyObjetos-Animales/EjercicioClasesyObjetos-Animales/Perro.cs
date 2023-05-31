using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    enum RazaPerro
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernardo
    }

    class Perro : Animal
    {
        //ATRIBUTOS

        private RazaPerro razaPerro;
        private string microchip;

        //CONSTRUCTOR
        public Perro(string nombre, DateTime fechaNacimiento, double peso,RazaPerro razaPerro, string microchip, string comentarios) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            this.razaPerro = razaPerro;
            this.microchip = microchip;
        }

        //PROPIEDADES

        public string Microchip
        {
            get { return microchip; }
        }

        public RazaPerro RazaPerro
        {
            get { return razaPerro; }
        }

        public override string ToString()
        {
            return "Ficha Perro" + "\n" + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Fecha de Nacimiento: " + fechaNacimiento + "\n" +
                   "Peso: " + peso + "\n" +
                   "Comentario: " + comentarios + "\n" +
                   "Raza: " + razaPerro + "\n" +
                   "Microchip: " + microchip;
        }
    }
}
