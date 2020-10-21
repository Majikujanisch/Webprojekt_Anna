using System;

namespace Webprojekt_Anna.Models
{
    public class Pokemon
    {
        public int Pokedex { get; set; }

        public string Name{ get; set; }
        public string Typ1 { get; set; }
        public string Typ2 { get; set; }
        public double Größe { get; set; }
        public Pokemon() : this(0,"","","",0.0) { }

        public Pokemon(int id, string name, string typ1, string typ2, double größe)
        {
            this.Pokedex = id;
            this.Name = name;
            this.Typ1 = typ1;
            this.Typ2 = typ2;
            this.Größe = größe;

        }

        public override string ToString()
        {
            return Pokedex + " " + Name + " " + Typ1 + " " + Typ2 + " " + Größe + " m";
        }




    }
}
