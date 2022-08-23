using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace FileHandling.Serialization.Assignments
{
    [Serializable]
    public class Product2
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class SoapSerialization1
    {
        static void SoapSerializationWrite(Product2 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, prod);
                Console.WriteLine("SOAP Data Added");
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
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Product2 prod = (Product2)sf.Deserialize(fs);
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
            //Product2 prod = new Product2 { ProductId = 1001, ProductName = "Book", Price = 5099.09 };
            //SoapSerializationWrite(prod);
            SoapSerializationRead();
        }
    }
}
