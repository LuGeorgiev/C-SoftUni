using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LectDemo
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("line.txt");
            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    var currentOddLine = lines[i];
                    result.Append(currentOddLine);
                    result.Append(Environment.NewLine);
                }
            }
            File.WriteAllText("..\\oddLinesNewLine.txt", result.ToString());


            ////LINQ solve
            //string[] lines = File.ReadAllLines("line.txt");
            //var oddLines = lines.Where((l, i) => i % 2 == 1);
            //File.WriteAllLines("..\\odd-textLinq.txt", oddLines);

        }
    }
}
