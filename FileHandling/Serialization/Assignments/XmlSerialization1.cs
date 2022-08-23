using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace FileHandling.Serialization.Assignments
{
    [Serializable]
    public class Product1
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class XmlSerialization1
    {
        static void XMLSerializationWrite(Product1 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\XMLFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product1));
                xs.Serialize(fs, prod);
                Console.WriteLine("XML Data Added");
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
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\XMLFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product1));
                Product1 prod = (Product1)xs.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Product1 prod = new Product1 { ProductId = 1001, ProductName = "Book", Price = 5099.09 };
            //XMLSerializationWrite(prod);
            XmlSerializationRead();
        }
    }
}
