using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    public interface IMobilable
    {
        void mob();
    }
    
    interface Isamsung:IMobilable
    {
        public static void Mob()
        {
            Console.WriteLine("Samsung Mobile");
        }
    }

    interface IApple:IMobilable
    {
        public static void Mob()
        {
            Console.WriteLine("Apple Mobile");
        }
    }

    interface INokia:IMobilable
    {
        public static void Mob()
        {
            Console.WriteLine("Nokia Mobile");
        }
    }

    class InterfaceHierarchical
    {
        static void Main(string[] args)
        {
            Isamsung.Mob();
            IApple.Mob();
            INokia.Mob();
        }
    }
}
