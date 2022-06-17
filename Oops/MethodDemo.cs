using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class MethodDemo
    {
        //accesmodifire returntype methodname(parameterlist)
        //{
             //logic
         //}

        //1.No return type no parameter

        public void show()
        {
            Console.WriteLine("show method");//method defination / body
        }

        //2. No return type with parameter
        public void Addition(int x,int y,double z)
        {
            Console.WriteLine("Addition=  " + (x + y + z));
        }

        //3.with return type no parameter
        public double Area()
        {
            double area = 3.14 * 4 * 4;
            return area;
        }

        //4.With return type with parameter
        public float calculate(int x,float y)
        {
            float ans = x * y;
            return ans;
        }

        static void Main(string[] args)
        {
            MethodDemo m = new MethodDemo();
            m.show();//method calling

            m.Addition(4, 3, 4.3);

            double ans = m.Area();
           // Console.WriteLine("Area of circle is= " + ans);
            Console.WriteLine("Area of circle is= " + m.Area());

            float result = m.calculate(5, 4.3f);
            Console.WriteLine("result");

            Console.WriteLine(m.calculate(5, 4.3f));

        }
    }
}
