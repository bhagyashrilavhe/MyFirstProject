using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    class PersonProperty
    {
        int id;
        string name;
        Address adr;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Adr
        {
            get { return adr; }
            set { adr= value; }
        }

        static void Main(string[] args)
        {
            PersonProperty p = new PersonProperty();
            p.Id = 11;
            p.Name = "Bhagya";
            
            p.Adr = new Address();

            p.Adr.Pincode = 412204;
            p.Adr.City = "Pune";

            Console.WriteLine(p.Id+" "+p.Name+" " + p.Adr.Pincode + " " + p.Adr.City);
        }
    }
}
