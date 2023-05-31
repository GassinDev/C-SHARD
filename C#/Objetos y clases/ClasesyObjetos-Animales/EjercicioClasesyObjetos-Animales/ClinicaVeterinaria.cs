using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClasesyObjetos_Animales
{
    class ClinicaVeterinaria
    {
        //ATRIBUTO

        protected List<Animal> listaAnimales;

        //CONSTRUCTOR
        public ClinicaVeterinaria()
        {
            listaAnimales = new List<Animal>();
        }

        //MÉTODOS

        public void InsertarAnimal(Animal a)
        {
            listaAnimales.Add(a);
        }

        public Animal BuscaAnimal(string nombre)
        {
            Animal a = null;

            for (int i = 0; i < listaAnimales.Count; i++)
            {
                a = listaAnimales[i];

                if (a.Nombre == nombre)
                {
                    i = listaAnimales.Count;
                }
            }

            if (a != null)
            {
                return a;
            }
            else
            {
                throw new Exception("Ningún animal tiene ese nombre");
            }
        }

        public void ModificaComentarioAnimal (string nombre, string comentario)
        {
            Animal a = BuscaAnimal(nombre);

            a.Comentarios = comentario;
        }
       

    }
}
