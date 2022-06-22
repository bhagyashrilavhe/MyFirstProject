using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{

    class Enginn
    {
        string cengin;

        public string Cengin
        {
            get { return cengin; }
            set { cengin = value; }
        }
    }
    class CarProperty
    {
        int modelno;
        string name;
        int price;
        Enginn engi;

        public int ModelNo
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get;
            set;
        }
        public Enginn Engi
        {
            get { return engi ; }
            set { engi = value; }
        }

        static void Main(string[] args)
        {
            CarProperty c = new CarProperty();
            c.ModelNo = 1111;
            c.Name = "BMW";
            c.Price = 40000;
            c.Engi = new Enginn();

            c.Engi.Cengin = "Disel";

            Console.WriteLine(c.ModelNo + " " + c.Name + "  " + c.Price + " " +c.Engi.Cengin);
        }

    }
}
