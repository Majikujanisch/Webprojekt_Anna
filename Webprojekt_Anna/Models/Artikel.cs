using System;

namespace Webprojekt_Anna.Models
{
    public class Artikel
    {
        public int ID { get; set; }

        public string ArticleName{ get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Artikel() : this(0,"","",DateTime.MinValue,0.0m,"") { }

        public Artikel(int id, string name, string brand, DateTime release,decimal price, string cate)
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
