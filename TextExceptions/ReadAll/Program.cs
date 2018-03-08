using System;
using System.IO;

namespace ReadAll
{
    class Program
    {
        static void Main()
        {
            var path = @"..\ivan.txt";
            //  .\ same directory
            // ..\ one directory UP
            //File.WriteAllText(path, "JavaScript is very cool, and  is very hard");

            var text = File.ReadAllText(@".\ivan.txt");
            //Console.WriteLine(text);

            var lines = new string[] {"Ivane", "Pesho", "Gosho" };

            File.WriteAllLines("dsda.txt", lines);
            File.AppendAllLines(".\\dsda.txt", lines);

            var fileInfo = new FileInfo("dsda.txt");
            Console.WriteLine(fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.FullName);

        }
    }
}
