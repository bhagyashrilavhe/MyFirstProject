using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{ 
    class Students
    {
        public string name = "Rutuja";
    }
    class Teachers : Students
    {
        public int id=1;
        public string subjectName = "Maths";

    }
    class HOD : Teachers
    {
        public int salary = 50000;

        public void show()
        {
            Console.WriteLine(name + " " + id + " " + subjectName + " " + salary);
        }
    }
    class MultilevelInheritance
    {
        static void Main( String[] args)
        {
            HOD h=new HOD();
            h.show();

        }
    }
}
