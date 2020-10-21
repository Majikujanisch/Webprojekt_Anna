using System;

namespace Webprojekt_Anna.Models
{
    public class Pokemon
    {
        public int Pokedex { get; set; }

        public string Name{ get; set; }
        public string Brand { get; set; }
        public string Typ1 { get; set; }
        public string Typ2 { get; set; }
        public double Größe { get; set; }
        public Pokemon() : this(0,"","","","",0.0m) { }

        public Pokemon(int id, string name, string brand, DateTime release,decimal price, string cate)
        {
            this.ID = id;
            this.ArticleName = name;
            this.Brand = brand;
            this.ReleaseDate = release;
            this.Price = price;
            this.Category = cate;

        }

        public override string ToString()
        {
            return ID + " " + ArticleName + " " + Brand + " " + ReleaseDate + " " + Price + " Euro" + Category;
        }




    }
}
