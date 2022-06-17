using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class StudentProperty
    {
        private int id;
        private string name;
        private float perc;
        private bool place;

        public int SId
        {
            get { return id; }
            set { id = value; }
        }
        public string Sname
        {
            get { return name; }
            set { name = value; }
        }
        public float Sperc
        {
            get { return perc; }
            set { perc = value; }
        }
        public bool Place
        {
            get { return place; }
            set { place = value; }
        }

        static void Main(String[] args)
        {
            StudentProperty s = new StudentProperty();
            s.SId = 101;
            s.Sname = "Rutu";
            s.Sperc = 82f;
            s.Place = true;


            Console.WriteLine(s.SId + " " + s.Sname + "  " + s.Sperc + "  " + s.Place);
        }

    }
}
