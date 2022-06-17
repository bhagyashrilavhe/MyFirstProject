using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class CarClass
    {
        int modelNo;
        string name;
        string color;
        int price;

        static void Main(String[] args)
        {
            CarClass c1 = new CarClass();
            c1.modelNo = 1201;
            c1.name = "Audi";
            c1.color = "Red";
            c1.price = 15000;

            Console.WriteLine("Model No : {c1.modelNo} Name : {c1.name} Color : {c1.color} Price : {c1.price}");


            CarClass c2 = new CarClass();
            c2.modelNo = 1202;
            c2.name = "BMW";
            c2.color = "Black";
            c2.price = 10000;

            Console.WriteLine("Model No : {c2.modelNo} Name : {c2.name} Color : {c2.color} Price : {c.price}");

            CarClass c3 = new CarClass();
            c3.modelNo = 1203;
            c3.name = "Swift Dzire";
            c3.color = "Green";
            c3.price = 17000;

            Console.WriteLine("Model No : {c3.modelNo} Name : {c3.name} Color : {c3.color} Price : {c3.price}");

        }
    }
}
