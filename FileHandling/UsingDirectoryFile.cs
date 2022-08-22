using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileHandling
{
    class UsingDirectoryFile
    {
        static void CreateFolder()
        {
            string path = @"D:\DotNet\TestFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }
        static void CreateFile()
        {
            string path = @"D:\DotNet\TestFolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }

        }

        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();

        }
    }
}
