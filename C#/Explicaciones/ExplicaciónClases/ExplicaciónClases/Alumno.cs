using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicaciónClases
{
    //class Alumno
    //{

    //    //ATRIBUTO
    //    public string nombre;
    //    public int edad;
    //    public double calificaciones;

    //    //CONSTRUCTORES
    //    public Alumno(string nombre1, int edad1, double calificaciones1)
    //    {
    //        nombre = nombre1;
    //        edad = edad1;
    //        calificaciones = calificaciones1;
    //    }

    //    //MÉTODOS
    //    public bool Aprovado();

    //    public bool Aprobado()
    //    {
    //        if(calificaciones >= 5)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }


    //    }

    //    public void AprobadoPorLaCara()
    //    {
    //        if (calificaciones < 5)
    //        {
    //            calificaciones = 5;
    //        }
    //    }
    class EquipoPokemon
    {
        private List<Pokemon> lista = new List<Pokemon>();

        public void InsertaPokemon(Pokemon p)
        {
            lista.Add(p);
        }
        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < lista.Count; i++)
            {
                cadena = cadena + lista[i].ToString() + "\n";
            }
            return cadena;
        }
    }

    enum TipoPokemon
    {
        Fuego, Planta, Agua, Bicho, Veneno, Psiquico,Siniestro
    }

    enum SexoPokemon
    {
        Macho, Hembra
    }
    class Pokemon
    {
        public int id;
        public string nombre;
        public int hpMax;
        public int hpActual;
        public int nivel;
        public TipoPokemon tipo;
        public SexoPokemon sexo;

        //CONSTRUCTOR
        public Pokemon(int id, string nombre, TipoPokemon tipo, SexoPokemon sexo, int hpMax, int hpActual, int nivel)
        {
            if(id >= 1 && id <= 151)
            {
                this.id = id;
            }
            else
            {
                throw new Exception("El ID tiene que estar entre 1 y 151");
            }
            if(nombre != "")
            {
                this.nombre = nombre;
            }
            else
            {
                throw new Exception("El Pokemon tiene que tener nombre");
            }
            if(hpMax > 0)
            {
                this.hpMax = hpMax;
            }
            else
            {
                throw new Exception("La vida del Pokémon tiene que ser positiva");
            }
            if(hpActual >= 0 && hpActual <= hpMax)
            {
                this.HpActual = hpActual;
            }
            else
            {
                throw new Exception("La vida del Pokemón actual no puede ser negativa ni mayor que la Max");
            }
            if(nivel >= 1 && nivel <= 100)
            {
                this.Nivel = nivel;
            }
            else
            {
                throw new Exception("El nivel tiene que estar entre 1 y 100");
            }
            this.id = id;
            this.nombre = nombre;
            this.hpMax = hpMax;
            this.Nivel = nivel;
            this.HpActual = hpActual;
            this.tipo = tipo;
            this.sexo = sexo;


        }

        //METODO
        public bool Desmayado()
        {
            if(HpActual == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string desm = " X_X";

            //if (Desmayado)
            //{
            //    desm;
            //}

            return "Pokemon:" + nombre + "(id: " + id + ")" + "level: " + nivel + ")";
        }

        public void BerberPoción()
        {
            if(HpActual + 20 <= HpMax)
            {
                hpActual = hpActual + 20;
            }
            else
            {
                hpActual = hpMax;
            }
        }

        //PROPIEDADES
        public int GetHpActual()
        {
            return this.HpActual;
        }

        public void SetHpActual(int nuevoValor)
        {
            if(nuevoValor >= 0 && nuevoValor <= hpMax)
            {
                this.HpActual = nuevoValor;
            }
            else
            {
                throw new Exception("La vida actual no puede ser negativa ni superior a la maxima");
            }
        }
        public int HpActual
        {
            get
            {
                return this.hpActual;
            }

            set
            {
                if (value >= 0 && value <= hpMax)
                {
                    this.hpActual = value;
                }
                else
                {
                    throw new Exception("La vida actual no puede ser negativa ni superior a la maxima");
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value >= 1 && value <= 151)
                {
                    this.id = value;
                }
                else
                {
                    throw new Exception("El ID tiene que estar entre 1 y 151");
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                if(value.Length > 0)
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("El nombre tiene que estar, si no esta me cago en tu puta madre");
                }
            }
        }

        public int HpMax
        {
            get
            {
                return hpMax;
            }

            set
            {
                if(value > 0)
                {
                    this.hpMax = value;
                }
                else
                {
                    throw new Exception("La vida del Pokemón tiene que ser positiva");
                }
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.nivel = value;
                }
                else
                {
                    throw new Exception("El nivel no puede ser menos de uno ni más de 100");
                }
            }
        }
    }


    
}



