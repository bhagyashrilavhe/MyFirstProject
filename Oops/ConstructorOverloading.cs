using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ConstructorOverloading
    {
        public ConstructorOverloading()
        {
            Console.WriteLine("Constructor Overloading");
        }
        public ConstructorOverloading(int x,int y)
        {
            Console.WriteLine("Result : " + (x + y));
        }
        public ConstructorOverloading(string str)
        {
            Console.WriteLine("City : "+str);

        }
        static void Main(String[] args)
        {
            ConstructorOverloading c = new ConstructorOverloading();
            ConstructorOverloading c1 = new ConstructorOverloading(5,7);
            ConstructorOverloading c3 = new ConstructorOverloading("Baramati");
        }
        
    }
}
