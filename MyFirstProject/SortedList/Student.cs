using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.SortedList
{
    class Stud:IComparable<Stud>
    {
        string name;
        long mno;
        int marks;

        public Stud(string name,long mno,int marks)
        {
            this.name = name;
            this.mno = mno;
            this.marks = marks;
        }

        public int CompareTo(Stud other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return " Name : " + name + " Mno : " + mno + " Marks : " + marks;
        }
        public string Name { get => name; set => name = value; }
        public long Mno { get => mno; set => mno = value; }
        public int Marks { get => marks; set => marks = value; }

    }
    class Student
    {
        static void Main(string[] args)
        {
            SortedList<Stud, string> sl = new SortedList<Stud, string>();

            sl.Add(new Stud("Raj", 9876542389l, 88), "Java");
            sl.Add(new Stud("Om",  9786234510l, 80), "Java");
            sl.Add(new Stud("Radha",9612458967l, 98), "Java");
            sl.Add(new Stud("Pari", 9877553629l, 77), "Java");
            sl.Add(new Stud("Piya", 9786452010l, 87), "Java");
            sl.Add(new Stud("Diya", 9607450229l, 70), "Java");



            foreach(KeyValuePair<Stud,string> kv in sl)
            {
                Console.WriteLine(kv.Key + "  ==>  "+kv.Value);
            }
        }
    }
}
