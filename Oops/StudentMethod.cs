using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class StudentMethod
    {
         public int id;
         public string name;
         int m1, m2, m3;

         int perc;
        public void AcceptDetails(int sid,string sname,int sub1,int sub2,int sub3)
        {
          id = sid;
          name = sname;
          m1 = sub1;
          m2 = sub2;
          m3 = sub3;
        }

        public void CalculatePerc()
        {
            perc = (m1 + m2 + m3 ) / 3;
        }
        public void Display()
        {
            Console.WriteLine("Id \t Name \t  m1  \t m2    \t m3  \t perc");
            Console.WriteLine(id+"    "+name+"   "+m1+"     "+m2+"     "+m3+"     "+perc);
        }

        static void Main(String[] args)
        {
            StudentMethod stud = new StudentMethod();

            stud.AcceptDetails(1,"Bhagyashri",66,89,77);
            stud.CalculatePerc();
            stud.Display();

        }
    }
}
