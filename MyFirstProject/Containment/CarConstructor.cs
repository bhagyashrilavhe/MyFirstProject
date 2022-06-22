using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{

    class Engin
    {
        public string engintype;
        
        public Engin(string engintype)
        {
            this.engintype = engintype;
        }
        
        public void show()
        {
            Console.WriteLine("Engine Type : " + engintype);
        }
    }
    class CarConstructor
    {
         int modelno;
         string name;
         double price;
         Engin engi;

        CarConstructor(int modelno,string name,double price,Engin engi)
        {
            this.modelno = modelno;
            this.name = name;
            this.price = price;
            this.engi = engi;
        }

        void display()
        {
            Console.WriteLine(modelno + " " + name + " " + price + " ");
            engi.show();
        }
        static void Main(string[] args)
        {
            
            CarConstructor c1 = new CarConstructor(1234, "BMW",50000.0, new Engin("Disel"));
            c1.display(); 
        }


    }
}
