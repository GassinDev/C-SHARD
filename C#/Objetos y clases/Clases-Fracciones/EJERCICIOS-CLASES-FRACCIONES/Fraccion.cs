using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_CLASES_FRACCIONES
{
    class Fraccion
    {
        //ATRIBUTOS
        private int numerador;
        private int denominador;

        //PROPIEDADES
        public int Numerador
        {
            get
            {
                return this.numerador;
            }

            set
            {
                this.numerador = value;
            }
        }

        public int Denominador
        {
            get
            {
                return this.denominador;
            }

            set
            {
                if (value != 0)
                {
                    this.denominador = value;
                }
                else
                {
                    throw new Exception("No puede ser 0");
                }
            }
        }

        //CONSTRUCTORES
        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion(int numerador)
        {
            Numerador = numerador;
            Denominador = 1;
        }

        public Fraccion(double numerador)
        {
            this.Denominador = 1;
            while (Math.Truncate(numerador) != numerador)
            {
                numerador = numerador * 10;
                Denominador = denominador * 10;
            }
            this.Numerador = (int)numerador;            
        }

        //METODOS
        public override string ToString()
        {
            return numerador + "/" + denominador ;
        }

        public void Simplificar()
        {
            int mcd = this.mcd(numerador, denominador);
            this.Numerador = numerador / mcd;
            this.Denominador = denominador / mcd;            
        }

        //METODOS PRIVADOS
        private int mcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }

                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        private int mcm(int a, int b)
        {
            int mcm = 0;
            mcm = (a * b) / mcd(a, b);
            return mcm;
        }

        //OPERATOR UNITARIO
        public static Fraccion operator -(Fraccion f)
        {
            int a = -f.numerador; 
            return new Fraccion(a, f.denominador);
        }

        //OPERATOR BINARIO
        public static Fraccion operator +(Fraccion f, Fraccion f2)
        {
            int mcm2 = f.mcm(f.denominador, f2.denominador);

            int resulnum;
            int resuldem;


            if (f.denominador == f2.denominador)
            {
                resulnum = f.numerador + f2.numerador;
                resuldem = f.denominador;
            }
            else
            {
                resulnum = ((mcm2 / f.denominador) * f.numerador) + ((mcm2 / f2.denominador) * f2.numerador);
                resuldem= mcm2;
            }

            return new Fraccion(resulnum, resuldem);
            
        }

        public static Fraccion operator -(Fraccion f, Fraccion f2)
        {
            int mcm2 = f.mcm(f.denominador, f2.denominador);

            int resulnum;
            int resuldem;


            if (f.denominador == f2.denominador)
            {
                resulnum = f.numerador - f2.numerador;
                resuldem = f.denominador;
            }
            else
            {
                resulnum = ((mcm2 / f.denominador) * f.numerador) - ((mcm2 / f2.denominador) * f2.numerador);
                resuldem = mcm2;
            }

            return new Fraccion(resulnum, resuldem);

        }

        public static Fraccion operator *(Fraccion f, Fraccion f2)
        {
            int resulnum;
            int resuldem;

            resulnum = f.numerador * f2.numerador;
            resuldem = f.denominador * f2.denominador;

            return new Fraccion(resulnum, resuldem);
        }

        public static Fraccion operator /(Fraccion f, Fraccion f2)
        {
            int resulnum;
            int resuldem;

            resulnum = f.numerador * f2.denominador;
            resuldem = f.denominador * f2.numerador;

            return new Fraccion(resulnum, resuldem);
        }





    }
}