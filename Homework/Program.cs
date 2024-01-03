using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Fayl nomini kiriting: ");
        string fileName = Console.ReadLine();

        string fullPath = FindFilePath(fileName);

        if (fullPath != null)
        {
            Console.WriteLine($"Fayl manzili: {fullPath}");
        }
        else
        {
            Console.WriteLine("Bunday nomli fayl topilmadi.");
        }
    }

    static string FindFilePath(string fileName)
    {
      
        string rootPath = @"C:\";

       
        string[] files = Directory.GetFiles(rootPath, fileName, SearchOption.AllDirectories);

        if (files.Length > 0)
        {
           
            return files[0];
        }
        else
        {
            
            return null;
        }
    }
}
