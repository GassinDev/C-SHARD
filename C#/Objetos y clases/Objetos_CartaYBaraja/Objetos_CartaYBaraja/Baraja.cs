using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_CartaYBaraja
{
    class Baraja
    {
        //ATRIBUTOS
        private List<Cartas> listaCartas = new List<Cartas>();

        //CONSTRUCTORES

        //Crea baraja vacia
        public Baraja() { }

        public Baraja(bool barajar)
        {
            for(int i = 1; i <= 40; i++)
            {
                listaCartas.Add(new Cartas(i));
            }

            if (barajar)
            {
                Barajar();
            }
        }

        //Baraja nuestra baraja
        public void Barajar()
        {
            Random r = new Random();
            List<Cartas> l2 = new List<Cartas>();

            int posi;

            while (listaCartas.Count > 0)
            {
                posi = r.Next(listaCartas.Count);
                l2.Add(listaCartas[posi]);
                listaCartas.RemoveAt(posi);
            }

            listaCartas.AddRange(l2);
        }

        public Cartas Robar()
        {
            if (listaCartas.Count > 0)
            {
                Cartas c = listaCartas[0];
                listaCartas.RemoveAt(0);
                return c;
            }
            else
            {
                throw new Exception("No quedan cartas");
            }
        }

        public void Contar(int numero)
        {
            if (numero < 1 || numero > listaCartas.Count - 1)
            {
                for (int i = 0; i < numero; i++)
                {
                    listaCartas.Add(listaCartas[0]);
                    listaCartas.RemoveAt(0);
                }
            }
            else
            {
                throw new Exception("Hay que cortar al menos una carta o dejar al menos una carta");
            }
        }

        public void InsertaCartaAlPrincipio(Cartas c)
        {
            listaCartas.Insert(0, c);
        }

        public void InsertaCartaAlPrincipio(int id)
        {
            listaCartas.Insert(0, new Cartas(id));
        }

        public void InsertaCartaAlFinal(Cartas c)
        {
            listaCartas.Add(c);
        }

        //PROPIEDADES

        //DEVUELVE LA CANTIDAD DE CARTAS QUE QUEDAN EN LA BARAJA
        public int NumeroCartas
        {
            get
            {
                return listaCartas.Count;
            }
        }

        public bool Vacia
        {
            get
            {
                return (listaCartas.Count == 0);
            }
        }
    }
}
