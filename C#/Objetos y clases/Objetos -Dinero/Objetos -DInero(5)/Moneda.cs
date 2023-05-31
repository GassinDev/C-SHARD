using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos__DInero_5_
{
    enum TipoMoneda
    {
        Dollar, Yen, Euro
    }

    class Moneda
    {
        //ATRIBUTOS
        private TipoMoneda tmoneda;
        private int decimales;
        private string simbolo;
        private decimal cambioEuro;

        //CONSTRUCTORES
        public Moneda (TipoMoneda tmoneda, int decimales, string simbolo, decimal cambioEuro)
        {
            this.decimales = decimales;

            this.tmoneda = tmoneda;

            if(simbolo != "")
            {
                this.simbolo = simbolo;
            }
            else
            {
                throw new Exception("Eso no es un símbolo de moneda");
            }

            if(decimales >= 0 && decimales <= 4)
            {
                this.decimales = decimales;
            }
            else
            {
                throw new Exception("Ese decimal es inválido");
            }
        }

        //PROPIEDADES  

        public int Decimales
        {
            get
            {
                return this.decimales;
            }
            set
            {
                this.decimales = value;
            }
        }

        public string Simbolo
        {
            get
            {
                return this.simbolo;
            }
            set
            {
                this.simbolo = value;
            }
        }

        public decimal CambioEuro
        {
            get
            {
                return this.cambioEuro;
            }
            set
            {
                if(value>= 0)
                {
                    this.cambioEuro = value;
                }
                else
                {
                    throw new Exception("No puede ser negativo");
                }
            }
        }

        public TipoMoneda tipoMoneda
        {
            get
            {
                return this.tmoneda;
            }
            set
            {
                this.tmoneda = value;
            }
        }

        //METODO
        public override string ToString()
        {
            string s = $"{tipoMoneda} {simbolo}";
            return s;
        }
    }
}
