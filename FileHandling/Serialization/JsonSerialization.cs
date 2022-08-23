using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace FileHandling.Serialization
{
    [Serializable]
    public class Student3
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
    }
    class JsonSerialization
    {
        static void JsonSerializationWrite(Student3 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student3>(fs, stud);
                Console.WriteLine("JSON data added");
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
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Student3 stud = JsonSerializer.Deserialize<Student3>(fs);
                Console.WriteLine(stud.RollNo);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Student3 stud = new Student3 { RollNo = 101, Name = "Bhagyashri", Percentage = 88.88 };
            //JsonSerializationWrite(stud);
            JsonSerializationRead();
        }
    }
}
