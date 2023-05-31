using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeComodo
    }

    class Reptil : Animal
    {
        protected EspecieReptil especieReptil;
        protected bool venenoso;

        public Reptil(string nombre, DateTime fechaNacimiento, double peso, string comentarios, EspecieReptil especieReptil, bool venenoso) : base(nombre, fechaNacimiento, peso, comentarios)
        {
            this.especieReptil = especieReptil;
            this.venenoso = venenoso;

        }

        public EspecieReptil EspecieReptil { get { return especieReptil; }}

        public bool Venenoso { get { return venenoso; } }

        public override string ToString()
        {
            return "Ficha Reptil" + "\n" + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Fecha de Nacimiento: " + fechaNacimiento + "\n" +
                   "Peso: " + peso + "\n" +
                   "Comentario: " + comentarios + "\n" +
                   "Especie: " + especieReptil + "\n" +
                   "Venenoso: " + venenoso;
        }
    }
}
