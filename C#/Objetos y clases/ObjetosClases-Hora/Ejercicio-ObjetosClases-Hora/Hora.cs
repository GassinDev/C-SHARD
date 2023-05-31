using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_ObjetosClases_Hora
{
    class Hora
    {
        //ATRIBUTOS
        private int segundos;

        //CONSTRUCTORES
        public Hora(int segundos)
        {
            SegundosTotales = segundos;
        }

        public Hora(int horas, int minutos, int segundos)
        {
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;    
        }

        //PROPIEDADES

        public int SegundosTotales
        {
            get { return segundos; }
            set {
                if (value >= 0)
                {
                    this.segundos = value;
                }
                else
                {
                    throw new Exception("No puede ser 0 ni negativo");
                }
            }
        }

        public int Segundos
        {
            get
            {
                return SegundosTotales - Horas * 3600 - Minutos * 60;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    SegundosTotales = Horas * 3600 + Minutos * 60 + value;
                }
                else
                {
                    throw new Exception("No puede ser 0 ni negativo");
                }
                
            }
        }

        public int Minutos
        {
            get
            {
                return (SegundosTotales / 60) - Horas * 60; ;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    SegundosTotales = Horas * 3600 + value * 60 + Segundos;
                }
                else
                {
                    throw new Exception("No puede ser 0 ni negativo");
                }
            }
        }

        public int Horas
        {
            get
            {
                return SegundosTotales / 3600;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    SegundosTotales = value * 3600 + Minutos * 60 + Segundos;
                }
                else
                {
                    throw new Exception("No puede ser 0 ni negativo");
                }
            }
        }

        //METODOS

        public void SumaHoras(int horas)
        {
            Horas = Horas + horas;
        }

        public void SumaMinutos(int minutos)
        {
            SegundosTotales = minutos * 60 + SegundosTotales;
        }

        public void SumaSegundos(int segundos)
        {
            SegundosTotales = segundos + SegundosTotales;
        }

        //METODO OPERADORES
        public static Hora operator +(Hora h1, Hora h2)
        {
            Hora ht = new Hora(h1.SegundosTotales + h2.SegundosTotales);
            return ht;
        }

        public static Hora operator -(Hora h1, Hora h2)
        {
            Hora ht = new Hora(h1.SegundosTotales - h2.SegundosTotales);
            return ht;
        }
        //METODO OVERRIDE

        public override string ToString()
        {
            return $"{Horas}:{Minutos}:{Segundos}";
        }
    }
}
