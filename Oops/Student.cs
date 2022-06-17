using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Student
    {
        public int id;
        public string name;
        public int marks;

        static void Main(String[] args)
        {
            /*Student stud;
            stud = new Student();
            stud.id = 22;
            stud.name = "Bhagyashri";
            stud.marks = 77;

            Console.WriteLine(stud.id + " " + stud.name + " " + stud.marks);*/

            Student s = new Student();
            s.id = 12;
            s.name = "Rutu";
            s.marks = 88;

            Console.WriteLine(s.id + " " + s.name + " " + s.marks);

        }
    }


    class StudentInfo
    {
        static void Main(String[] args)
        {
            StudentInfo s1 = new StudentInfo();
            /*s1.id = 1;
            s1.name = "Priya";
            s1.marks = 78;
            Console.WriteLine(s1.id + " " + s1.name + " " + s1.marks);*/
        }
    }
}
