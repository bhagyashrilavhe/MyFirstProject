using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Sport
    {
        public void Display()
        {
            Console.WriteLine(" ******* Sports *******");
        }
    }
    class Cricket : Sport
    {
        public int worldCupYear = 2011;
        
    }
    class Football : Sport
    {
        public string captain = "Sunil Chhetri";
    }
    class  Hockey: Sport
    {
        public int playersNum = 11;
    }
    class HierarchicalInheritance1
    {
        static void Main(String[] args)
        {
            Cricket c = new Cricket();
            Console.WriteLine("Cricket-   " + c.worldCupYear+ "  -worldCupYear");

            Football f = new Football();
            Console.WriteLine("Football-  " + f.captain+ "  -captain");

            Hockey h = new Hockey();
            Console.WriteLine("Hockey-   "+h.playersNum+ "  -playersNum");


        }
    }
}
