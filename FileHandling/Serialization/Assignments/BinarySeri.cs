using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileHandling.Serialization.Assignments
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class BinarySeri
    {
        static void BinarySerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, prod);
                Console.WriteLine("Binary Data Added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet\TestFolder1\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Product prod = (Product)bf.Deserialize(fs);
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
           // Product prod = new Product { ProductId = 1001, ProductName = "Book", Price = 5099.09  };
            //BinarySerializationWrite(prod);
            BinarySerializationRead();
        }
    }
}
