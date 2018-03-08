using System;
using System.Collections.Generic;
using System.Linq;

namespace Nov17Threat
{
    class Threat
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();
            
            while (true)
            {
                string commands = Console.ReadLine();
                if (commands=="3:1")
                {
                    break;
                }

                string action = commands.Split(' ')[0];
                int first = int.Parse(commands.Split(' ')[1]);
                int second = int.Parse(commands.Split(' ')[2]);

                if (action == "merge")
                {
                    input = MergeInput(input, first, second);
                }
                else if (action == "divide")
                {
                    input = DivideInput(input, first, second);

                }

            }
                Console.WriteLine(string.Join(" ",input));
        }

        private static List<string> MergeInput(List<string> input, int first, int second)
        {
            var result = new List<string>();
            int startIndex = first;
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex>=input.Count-1)
            {
                return input;
            }

            int endIndex = second;
            if (endIndex >= input.Count - 1)
            {
                endIndex = input.Count - 1;
            }
            else if (endIndex<=0)
            {
                return input;
            }

            for (int i = 0; i < startIndex; i++)
            {
                result.Add(input[i]);
            }
            string merged = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += input[i];
            }
            result.Add(merged);
            for (int i = endIndex+1; i < input.Count; i++)
            {
                result.Add(input[i]);
            }

            return result;
        }

        private static List<string> DivideInput(List<string> input, int index, int partitions)
        {
            var result = new List<string>();

            if (partitions<=0)
            {
                return input;
            }
            for (int i = 0; i < index; i++)
            {
                result.Add(input[i]);
            }

            int toDevideLength = input[index].Length;
            int symbInPartition = toDevideLength / partitions;
            string newPartition = "";

            int symbolCount = 0;
            int partitionCount = 0;
            bool isvalidToAdd = false;
            foreach (var symbol in input[index])
            {
                newPartition += symbol;
                symbolCount++;
                // to add devided symbols
                if (symbolCount== symbInPartition&& partitionCount< partitions-1)
                {
                    result.Add(newPartition);
                    newPartition = "";
                    partitionCount++;
                    isvalidToAdd = true;
                    symbolCount = 0;
                }
            }
            if (isvalidToAdd)
            {
                result.Add(newPartition);
            }

            for (int i = index+1; i < input.Count; i++)
            {
                result.Add(input[i]);
            }
            return result;
        }
    }
}
