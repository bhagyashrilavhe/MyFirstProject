using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class Nib
    {
        string materialType;
        double width;

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Refill
    {
        string inkColor;
        double length;
        Nib ni;

        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib Ni
        {
            get { return ni; }
            set { ni = value; }
        }
    }

    class Structure
    {
        Refill refi;
        double capLength;
        string brand;

        public  Refill Refi
        {
            get { return refi; }
            set { refi = value; }
        }
        public double CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        static void Main(String [] args)
        {
            Structure s = new Structure();
            s.CapLength = 13.2;
            s.Brand = "Ball Pen";
            s.Refi = new Refill();

            s.Refi.InkColor = "Black";
            s.Refi.Length =  12.4;
            s.Refi.Ni = new Nib();

            s.Refi.Ni.MaterialType = "Plastic";
            s.Refi.Ni.Width =1.2;

            Console.WriteLine(s.CapLength+ " " + s.Brand + "  " + s.Refi.InkColor + " " + s.Refi.Length+" " + s.Refi.Ni.MaterialType + " " + s.Refi.Ni.Width);
        }
        
    }
}
