using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class FiveSubTotalAverageAndperce
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Physics Marks : ");
            int phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry Marks : ");
            int che = int.Parse(Console.ReadLine());
            Console.WriteLine("Mathematics Marks : ");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("English Marks : ");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Biology Marks : ");
            int bio = int.Parse(Console.ReadLine());

            float total, average, percentage;

            total = phy + che + math + eng + bio;
            Console.WriteLine("Total of 5 subject marks " + total);

            average = total / 5;
            Console.WriteLine("Average of 5 subject marks " + average);

            percentage = (total / 500) * 100;
            Console.WriteLine("Percentage of 5 subject marks " + percentage);
        }
    }
}
