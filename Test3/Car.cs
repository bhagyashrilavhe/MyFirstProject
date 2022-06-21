using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class Gear
    {
        public string geartype;

        public Gear(string geartype)
        {
            this.geartype = geartype;
        }

        public void show()
        {
            Console.WriteLine(geartype);
        }
    }
    class SubEngine
    {
        public string subenginetype;

        public SubEngine(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }

        public void show()
        {
            Console.WriteLine( subenginetype);
        }

    }
    class Engine
    {
        public int engineId;
        public string lastenginecleandate;
        SubEngine subengi;

        public Engine(int engineId, string lastenginecleandate, SubEngine subengi)
        {
            this.engineId = engineId;
            this.lastenginecleandate = lastenginecleandate;
            this.subengi = subengi;
        }
        public void show()
        {
            Console.WriteLine(engineId+" "+ lastenginecleandate+" "+ subengi);
            subengi.show();
        }

    }
   
    class Car
    {

        int carId;
        string carColor;
        Engine engi;
        Gear ger;

        Car(int carId, string carColor, Engine engi, Gear ger)
        {
            this.carId = carId;
            this.carColor = carColor;
            this.engi = engi;
            this.ger = ger;
        }

        void display()
        {
            Console.WriteLine(carId + " " + carColor);
            engi.show();
            ger.show();
        }
        static void Main(String [] args)
        {
            
            Car c = new Car(1111,"Black",new Engine(101, "23-05-2019", new SubEngine("Disel")), new Gear("Auto Manual"));

            c.display();
            
        }
    }
}
