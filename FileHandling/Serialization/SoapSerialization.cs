using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace FileHandling.Serialization
{
    [Serializable]
    public class Student2
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
    }
    class SoapSerialization
    {
        static void SoapSerializationWrite(Student2 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, stud);
                Console.WriteLine("SOAP data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Student2 stud = (Student2)sf.Deserialize(fs);
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
            //Student2 stud = new Student2 { RollNo = 101, Name = "Bhagyashri", Percentage = 88.88 };
            //SoapSerializationWrite(stud);
            SoapSerializationRead();
        }
    }
}
