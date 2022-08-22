using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileHandling
{
    class WriteReadFileUsingBinaryWR
    {
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Fees { get; set; }

        }

        static void WriteToFile(Course course)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\TestFile1", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(course.Id);
                bw.Write(course.Name);
                bw.Write(course.Fees);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data Added to File");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\TestFile1", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32()); 
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Course course = new Course { Id = 1, Name = "C #", Fees = 40000 };
            
           // WriteToFile(course);
            ReadFromFile();
        }
    }
}
