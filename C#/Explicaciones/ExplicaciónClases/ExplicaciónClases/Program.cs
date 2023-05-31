using System;
using System.Collections.Generic;
using System.Text;


namespace ExplicaciónClases
{
  class Program
  {
        static void Main(string[] args)
        {
                //ATRIBUTOS
                //Pokemon p = new Pokemon();

                //p.id = 1;
                //p.nombre = "Bulbasaur";
                //p.hpMax = 15;
                //p.hpActual = 15;
                //p.nivel = 1;
                //p.desmayado = false;

                Pokemon p = new Pokemon(1, "Bulbasaur", TipoPokemon.Planta, SexoPokemon.Hembra, 15, 15, 1);
                Pokemon p2 = new Pokemon(1, "charmander", TipoPokemon.Fuego, SexoPokemon.Hembra, 13, 13, 1);
                Pokemon p3 = new Pokemon(1, "pulbasaur", TipoPokemon.Agua, SexoPokemon.Macho, 12, 12, 1);

            EquipoPokemon ep = new EquipoPokemon();
            ep.InsertaPokemon(p);
            ep.InsertaPokemon(p2);
            ep.InsertaPokemon(p3);
            Console.WriteLine(ep);

            //Pokemon chungo = new Pokemon(100, "Voltorb", 24, 12, 2);
            //chungo.SetHpActual(200);
            //Console.WriteLine(chungo.HpActual);
            //Console.WriteLine(chungo.Desmayado());

            //Console.WriteLine(p);
            //p.HpActual = 0;
            //Console.WriteLine("Vida = " + p.HpActual);
            //Console.WriteLine("Desmayado = " + p.Desmayado);
            //p.BerberPoción();
            //Console.WriteLine("Vida = " + p.HpActual);
            //Console.WriteLine("Desmayado = " + p.Desmayado);


            //Alumno a = new Alumno();

            //a.nombre = "patata";
            //a.calificaciones = 3.4;
            //a.edad = 15;

            //Console.WriteLine(a.Aprobado());
            //a.AprobadoPorLaCara();
            //Console.WriteLine(a.calificaciones);
            //Console.WriteLine(a.Aprobado());

            //Alumno a2 = new Alumno();

            //a2.nombre = "tomate";
            //a2.calificaciones = 7;
            //a2.edad = 24;

            //Console.WriteLine(a2.Aprobado());

            //Alumno a3 = new Alumno("pimiento", 8.5, 30);
        }
  }
}
