using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{ 
    class Emp
    {
        int eno;
        string name;
        string deptname;

        public Emp(int eno,string name,string deptname)
        {
            this.eno = eno;
            this.name = name;
            this.deptname = deptname;
        }
        public override string ToString()
        {
            return " Eno : " + eno + "  Name : " + name + "  DeptName : " + deptname;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
    }
    class EmpLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<Emp> ll = new LinkedList<Emp>();

            ll.AddLast(new Emp(1, " AA", " IT"));
            ll.AddLast(new Emp(3, " BB", " Testing"));
            ll.AddLast(new Emp(5, " CC", " HR"));
            ll.AddLast(new Emp(7, " DD", " IT"));
            ll.AddLast(new Emp(10," EE", " IT"));
            ll.AddLast(new Emp(2, " FF", " HR"));
            ll.AddLast(new Emp(11," GG", " Testing"));

            String dname = "";
            foreach(Emp e in ll)
            {
                if(e.Eno==10)
                {
                    dname = e.Deptname;
                    break;
                }
            }

            foreach(Emp e in ll)
            {
                if(e.Deptname==dname)
                {
                    Console.WriteLine(e);
                }
            }
            
        }
    }
}
