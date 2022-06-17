using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal is Eating......");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog is Eating Bread ......");
        }

    }

    class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat is Drinking  Milk......");
        }

    }
    class OverridingExample
    {
        static void Main(String [] args)
        {
            //Dog d = new Dog();
           // d.eat();

            Animal a = new Animal();
            a.eat();

            Animal a1 = new Dog();
            a1.eat();

            Animal a2 = new Cat();
            a2.eat();

        }
    }
}
