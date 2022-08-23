using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FileHandling.Serialization
{
    [Serializable]
    public class Student1
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
    }
    class XMLSerialization
    {
        static void XMLSerializationWrite(Student1 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\XMLFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Student1));
                xs.Serialize(fs, stud);
                Console.WriteLine("XML data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder\XMLFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student1));
                Student1 stud = (Student1)xs.Deserialize(fs);
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
            //Student1 stud = new Student1 { RollNo = 101, Name = "Bhagyashri", Percentage = 88.88 };
            //XMLSerializationWrite(stud);
            XmlSerializationRead();
        }
    }
}
