using System;
using System.Collections.Generic;
using System.Linq;

namespace HwLists
{
    class Program
    {
        //1.Max Sequence of Equal Elements
        public static void MaxSequenceOfEqual(string str)
        {
            List<int> list = str.Trim().Split(' ').Select(int.Parse).ToList();
            int maxEndIndex = 0;
            int longestSequence = 1;
            int currentSequence = 1;
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i]==list[i+1])
                {
                    currentSequence++;
                    if (currentSequence> longestSequence)
                    {
                        longestSequence = currentSequence;
                        maxEndIndex = i+1;
                    }                    
                }
                else
                {
                    currentSequence = 1;
                }
            }

            for (int i = maxEndIndex; i > maxEndIndex- longestSequence; i--)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
        }
        //2.	Change List
        public static void ChangeList(string strOfInts)
        {
            List<int> intList = strOfInts.Trim().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="Even"&&command!="Odd")
            {
                string[] nextAction = command.Split(' ').ToArray();
                if (nextAction[0]=="Delete")
                {
                    int toDelete = int.Parse(nextAction[1]);
                    intList.RemoveAll(x => x == toDelete);                    
                }
                else if (nextAction[0] == "Insert")
                {
                    int toInsertValue = int.Parse(nextAction[1]);
                    int toInsertPosition = int.Parse(nextAction[2]);
                    intList.Insert(toInsertPosition, toInsertValue);
                }
                command = Console.ReadLine();
            }

            if (command == "Even")
            {
                List<int> even = intList.Where((x, i) => x % 2 == 0).ToList();
                PrintList(even);
            }
            else if (command == "Odd")
            {
                List<int> odd = intList.Where((x, i) => x % 2 == 1).ToList();
                PrintList(odd);

            }
        }
        private static void PrintList(List<int> list)
        {
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");

            }
            
            Console.WriteLine();
        }
        //3.	Search for a Number
        static void SearchForNumber(string line, string threeDigits)
        {
            List<int> intList= line.Trim().Split(' ').Select(int.Parse).ToList();
            int[] commands = threeDigits.Trim().Split(' ').Select(int.Parse).ToArray();

            List<int> firstTaken = new List<int>(commands[0]);
            for (int i = 0; i < commands[0]; i++)
            {
                firstTaken.Add(intList[i]);
            }
            

            List<int> restElement = new List<int>();
            for (int i = commands[1]; i < firstTaken.Count; i++)
            {
                restElement.Add(firstTaken[i]);
            }
            
            if (restElement.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
        //4.Longest Increasing Subsequence(LIS)
        private static void FindLongestIncreasingSequence(string intSequence)
        {
            int[] intLine = intSequence.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            long combinations = 1 << intLine.Length;
            List<int> longestIncreasingSec = new List<int>();
            longestIncreasingSec.Add(intLine[0]);
            List<int> tempSequence = new List<int>();

            for (long i = 1; i <= combinations; i++)
            {
                tempSequence.Clear();
                bool isIncreasing = true;
                //generate all different sequencies
                for (int j = 0; j < intLine.Length; j++)
                {
                    if (((1<<j)&i)>0)
                    {
                        tempSequence.Add(intLine[j]);

                        //check if sequence is increasing
                        if (tempSequence.Count>1)
                        {
                            if (tempSequence[tempSequence.Count-1]<=tempSequence[tempSequence.Count - 2])
                            {
                                isIncreasing = false;
                                break;
                            }
                        }
                    }
                }
                //check if this is the longest sequence
                if (isIncreasing && tempSequence.Count> longestIncreasingSec.Count)
                {
                    longestIncreasingSec.Clear();
                    longestIncreasingSec.AddRange(tempSequence);
                }
            }            

            foreach (var item in longestIncreasingSec)
            {
                Console.Write(item+" ");
            }
                Console.WriteLine();
        }
        //4 Soft UNI Studend 
        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
        //5.Array Manipulator
        private static void ArrayToManupulate(string intLine)
        {
            List<int> toManupulate = intLine
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command!="print")
            {
                string[] commands = command
                    .Split(' ')
                    .ToArray();

                if (commands[0]=="add")
                {
                    toManupulate.Insert(int.Parse(commands[1]),int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    //ot tuka gurmi
                    List<int> range = commands
                        .Where((x, i) => i > 1)
                        .Select(int.Parse)
                        .ToList();
                    toManupulate.InsertRange(int.Parse(commands[1]), range);
                }
                else if (commands[0] == "contains")
                {
                    Console.WriteLine(toManupulate.IndexOf(int.Parse(commands[1])));                    
                }
                else if (commands[0] == "remove")
                {
                    toManupulate.RemoveAt(int.Parse(commands[1])); 
                }
                else if (commands[0] == "shift")
                {
                    //toManupulate.Reverse(0,int.Parse(commands[1]));
                    //toManupulate.Reverse(int.Parse(commands[1]), toManupulate.Count- int.Parse(commands[1]));
                    //toManupulate.Reverse();

                    //worksop way
                    int rotations = int.Parse(commands[1]);
                    for (int i = 0; i < rotations; i++)
                    {
                        toManupulate.Add(toManupulate[0]);
                        toManupulate.RemoveAt(0);
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    for (int i = 0; i < toManupulate.Count - 1; i++)
                    {
                        toManupulate[i] += toManupulate[i + 1];
                        toManupulate.RemoveAt(i + 1);
                    }               

                }

                command = Console.ReadLine();
            }
            PrintListFive(toManupulate);
        }
        private static void PrintListFive(List<int> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write(list[i] + ", ");

            }
            Console.Write(list[list.Count - 1] + "]");
            Console.WriteLine();
        }

        static void Main()
        {
            //1.Max Sequence of Equal Elements
            //string sequenceOfInts = Console.ReadLine();
            //MaxSequenceOfEqual(sequenceOfInts);

            //2.	Change List
            //string sequenceOfInts = Console.ReadLine();
            //ChangeList(sequenceOfInts);

            //3.Search for a Number
            //string line = Console.ReadLine();
            //string arrOfThree = Console.ReadLine();
            //SearchForNumber(line, arrOfThree);

            //4.Longest Increasing Subsequence(LIS)
            //string intSequence = Console.ReadLine();
            //FindLongestIncreasingSequence(intSequence);

            //4. Soft UNI Decision
            //int[] lis = FindLongestIncreasingSubsequence(Console.ReadLine().
            //    Split(' ')
            //    .Select(int.Parse)
            //    .ToArray());
            //foreach (var item in lis)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();

            //5.Array Manipulator
            string toManupilate = Console.ReadLine();
            ArrayToManupulate(toManupilate);
        }

    }
}
