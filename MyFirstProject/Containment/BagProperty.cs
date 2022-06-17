using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Nib
    {
        string nibType;

        public string NibType
        {
            get { return nibType; }
            set { nibType = value; }
        }
    }
    class Pen
    {
        string penName;
        string color;
        Nib n;

        public string PenName
        {
            get { return penName; }
            set { penName = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }
    }

    class BagProperty
    {
        string bagName;
        string color;
        string brandName;
        int price;
        Pen p;

        public string BagName
        {
            get { return bagName; }
            set { bagName = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string BrandName
        {
            get { return brandName; }
            set { brandName = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }
        static void Main(String[] args)
        {
            BagProperty b = new BagProperty();
            b.BagName = "Sack";
            b.Color = "Black";
            b.BrandName = "Nike";
            b.Price = 1000;
            b.P = new Pen();

            b.p.PenName = "Bally";
            b.p.Color = "Blue";
            b.p.N = new Nib();

            b.p.N.NibType = "Plastic";
            Console.WriteLine(b.BagName + " " + b.Color + " " + b.BrandName + " " + b.Price + " " + b.p.PenName + " " + b.p.Color + " " + b.p.N.NibType);

        }
    }

}
