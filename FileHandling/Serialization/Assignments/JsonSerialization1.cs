using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace FileHandling.Serialization.Assignments
{
    [Serializable]
    public class Product3
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class JsonSerialization1
    {
        static void JsonSerializationWrite(Product3 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Product3>(fs, prod);
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
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\JsonFile.json", FileMode.Open, FileAccess.Read);
                Product3 prod = JsonSerializer.Deserialize<Product3>(fs);
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
            //Product3 prod = new Product3 { ProductId = 1001, ProductName = "Book", Price = 5099.09 };
            //JsonSerializationWrite(prod);
            JsonSerializationRead();
        }
    }
}
