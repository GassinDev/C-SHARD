using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis
    }

    class Pajaro : Animal
    {
        //ATRIBUTOS
        protected EspeciePajaro especiePajaro;
        protected bool cantor;

        //CONSTRUCTOR
        public Pajaro(string nombre, DateTime fechaNacimiento, double peso, string comentarios, EspeciePajaro especiePajaro, bool cantor) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            this.cantor = cantor;
            this.especiePajaro = especiePajaro;
        }

        //PROPIEDADES
        
        public bool Cantor { get { return cantor; }}

        public EspeciePajaro EspeciePajaro { get { return especiePajaro; }}

        public override string ToString()
        {
            return "Ficha Pajaro" + "\n" + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Fecha de Nacimiento: " + fechaNacimiento + "\n" +
                   "Peso: " + peso + "\n" +
                   "Comentario: " + comentarios + "\n" +
                   "Especie: " + especiePajaro + "\n" +
                   "Cantor: " + cantor;
        }
    }
}
