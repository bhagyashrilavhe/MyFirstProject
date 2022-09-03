using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace FileHandling.Serialization.Assignment03_09022
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Fees { get; set; }
        public string Duration { get; set; }
    }
    class JsonSeriCourse
    {
        static void JsonSerializationWrite(Course course)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\CourseFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Course>(fs,course);
                Console.WriteLine("JSON Data Added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\CourseFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Course course = JsonSerializer.Deserialize<Course>(fs);
                Console.WriteLine(course.CourseId);
                Console.WriteLine(course.CourseName);
                Console.WriteLine(course.Fees);
                Console.WriteLine(course.Duration);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Course course = new Course { CourseId = 1001, CourseName = "C#", Fees = 40000,Duration="3 Months" };
            //JsonSerializationWrite(course);
            JsonSerializationRead();

        }
    }
}
