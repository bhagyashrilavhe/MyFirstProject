using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to create List of Students and iterate over it.
    class StudentList
    {
        int id;
        string name;
        int age;

        public override string ToString()
        {
            return id + " " + name + " " + age;
        }
        static void Main(string[] args)
        {
            List<StudentList> student = new List<StudentList>();
           

            student.Add(new StudentList { id = 101, name = "Rutvi  ", age = 12 });
            student.Add( new StudentList { id = 102, name ="Rutuja ", age = 18 });
            student.Add(new StudentList { id = 103, name = "Priya  ", age = 20 });
            student.Add(new StudentList { id = 104, name = "Afrin  ", age = 16 });
            student.Add(new StudentList { id = 105, name = "Supriya", age = 22 });
            
            Console.WriteLine("Student List : "); 

            Console.WriteLine("ID   NAME   AGE");
            Console.WriteLine("*******************");

            foreach(StudentList s in student)
            {
                Console.WriteLine(s.ToString());
            }
            

        }
    }
}
