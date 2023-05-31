using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_CartaYBaraja
{
    enum TipoPalo
    {
        Bastos, Copas, Oro, Espadas
    }

    class Cartas
    {
        //ATRIBUTOS
        private int numero;
        private TipoPalo palo;

        //CONSTRUCTORES
        public Cartas(int numero, TipoPalo palo)
        {
            if (numero >= 1 && numero <= 10 && numero != 8 && numero != 9)
            {
                this.numero = numero;
            }
            else
            {
                throw new Exception("La carta no puede ser menor de 1 ni mayor de 12, ni tampoco 8 y 9");
            }


        }

        public Cartas(int id)
        {

            if(id >= 1 && id <= 40)
            {
                if(id >= 1 && id <= 10)
                {
                    if(id <= 7)
                    {
                        numero = id;
                    }
                    else
                    {
                        numero = (id) + 2;
                    }
                    
                    palo = TipoPalo.Oro;
                }
                else
                {
                    if (id > 10 && id <= 20)
                    {
                        if (id <= 7)
                        {
                            numero = id - 10;
                        }
                        else
                        {
                           numero = (id - 10) + 2;
                        }
                        palo = TipoPalo.Copas;
                    }
                    else
                    {
                        if (id > 20 && id <= 30)
                        {
                            if (id <= 7)
                            {
                                numero = id - 10;
                            }
                            else
                            {
                                numero = (id - 10) + 2;
                            }
                            palo = TipoPalo.Espadas;
                        }
                        else
                        {
                            if (id > 30 && id <= 40)
                            {
                                if (id <= 7)
                                {
                                    numero = id - 10;
                                }
                                else
                                {
                                    numero = (id - 10) + 2;
                                }

                                palo = TipoPalo.Bastos;
                            }
                        }
                    }
                }


            }
            else
            {
                throw new Exception("Tiene que ser mayor e igual que 1 o menor o igual de 40");
            }

            
            
        }

       public TipoPalo PaloCarta
       {
            get
            {
                return this.palo;
            }

           
       }

        public int NumeroCarta
        {
            get
            {
                return this.numero;
            }
        }

        //PROPIEDADES

        public string NombreNumero
        {
            get
            {


                switch (numero)
                {
                    case 1: return "as";
                    case 2: return "dos";
                    case 3: return "tres";
                    case 4: return "cuatro";
                    case 5: return "cinco";
                    case 6: return "seis";
                    case 7: return "siete";
                    case 10: return "sota";
                    case 11: return "caballo";
                    case 12: return "rey";

                    //string[]=  "" "uno" "dos" "tres"
                    // return string[this.numero];

                    default: return "";
                }
            }
            
        }

        public string NombrePalo
        {
            get
            {
                switch (this.palo)
                {
                    case TipoPalo.Bastos: return "Bastos";
                        
                    case TipoPalo.Copas: return "Copas";
                        
                    case TipoPalo.Oro: return "Oros";
                        
                    case TipoPalo.Espadas: return "Espadas";
                      
                    default: return "";
                }

            }

        }

        public string NombreCarta
        {

            get
            {

                return NombreNumero + " de " + NombrePalo;
                
            }
        }

        public int ValorTute
        {
            get
            {
                switch (numero)
                {
                    case 1: return 11;
                    case 3: return 10;
                    case 10: return 2;
                    case 11: return 3;
                    case 12: return 4;

                    default: return numero;
                }
            }
        }

        public int ValorMus
        {
            get
            {
                switch (numero)
                {
                    case 1: return 1;
                    case 2: return 2;
                    case 3: return 10;
                    case 10: return 2;
                    case 11: return 3;
                    case 12: return 4;

                    default: return numero;
                        
                }
            }
        }

        public decimal Valor7ymedia
        {
            get
            {
                switch (numero)
                {
                    case 10: return 0.5m;
                    case 11: return 0.5m;
                    case 12: return 0.5m;

                    default: return numero;

                }
            }
        }

        //METODOS

        public override string ToString()
        {
            return this.NombreCarta;
        }


    }

   

}
