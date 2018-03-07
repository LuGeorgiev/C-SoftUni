using System;
using System.Linq;
using System.Collections.Generic;

namespace HWArrayFirst
{
    class ArrayOne
    {
        //1.	Largest Common End
        private static void LargestCommonEnd(string first, string second)
        {
            int countLargestFromRight = 0;
            int countLargestFromLeft = 0;
            string[] firstArray = first.Split(' ');
            string[] secondArray = second.Split(' ');
            int lengthOfShorter = firstArray.Length < secondArray.Length
                ? firstArray.Length
                : secondArray.Length;
            for (int i = 0; i < lengthOfShorter; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    countLargestFromLeft++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i <= lengthOfShorter; i++)
            {
                if (firstArray[firstArray.Length - i] == secondArray[secondArray.Length - i])
                {
                    countLargestFromRight++;
                }
                else
                {
                    break;
                }
            }

            int longest = countLargestFromRight > countLargestFromLeft
                ? countLargestFromRight
                : countLargestFromLeft;
            Console.WriteLine(longest);
        }
        //2.Rotate and Sum
        private static void RotateSum(string arr, int cycles)
        {
            int[] array = arr.Split(' ').Select(int.Parse).ToArray();
            int[] result = Enumerable.Repeat(0, array.Length).ToArray();
                //new int[array.Length];
            int firstNum = 0;
            for (int i = 1; i <= cycles; i++)
            {
                firstNum = array[array.Length - 1];
                for (int j = array.Length-1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = firstNum;
                for (int j = 0; j < array.Length; j++)
                {
                    result[j] += array[j];
                }

            }

            //Console.WriteLine(String.Join(' ',result));
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]+" ");
            }
            Console.WriteLine();
        }
        //3.	Fold and Sum 
        private static void FoldSum(string line)
        {
            int[] arr = line.Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length/4;
            int[] firstLine = new int[2 * k];
            int[] secondLine = new int[2 * k];
            for (int i = 0; i < 2*k; i++)
            {
                secondLine[i] = arr[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                firstLine[i] = arr[k - i-1];
            }
            for (int i = 0; i < k; i++)
            {
                firstLine[i+k] = arr[4*k - i -1];
            }

            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstLine[i]+secondLine[i]+" ");
            }
            Console.WriteLine();
        }
        //4.	Sieve of Eratosthenes
        private static void Eratosthenes(int lastNumer)
        {
            var allNumbers = new List<int>(lastNumer);
            for (int i = 2; i <= lastNumer; i++)
            {
                allNumbers.Add(i);
            }
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i]!=0)
                {
                    Console.Write(allNumbers[i] + " ");
                    int gap = allNumbers[i];
                    for (int j = i; j < allNumbers.Count; j+= gap)
                    {
                        allNumbers[j] = 0;
                    }
                }
            }
            Console.WriteLine();
        }
        //5.Compare Char Arrays
        static void CompareLexicographically(string first, string second)
        {
            string stringA = first.Replace(" ", String.Empty);
            string stringB = second.Replace(" ", String.Empty);

            int orderString = stringA.CompareTo(stringB);
            if (orderString == -1)
            {
                Console.WriteLine(stringA);
                Console.WriteLine(stringB);
            }
            else
            {
                Console.WriteLine(stringB);
                Console.WriteLine(stringA);
            }

        }
        static void Main(string[] args)
        {
            //1.Largest Common End
            //string firstWord = Console.ReadLine();
            //string secondWord = Console.ReadLine();
            //LargestCommonEnd(firstWord,secondWord);

            //2.Rotate and Sum
            //string arr = Console.ReadLine();
            //int cycles = int.Parse(Console.ReadLine());
            //RotateSum(arr, cycles);

            //3.Fold and Sum
            //string line = Console.ReadLine();
            //FoldSum(line);

            //4.	Sieve of Eratosthenes
            //    int lastNumer = int.Parse(Console.ReadLine());
            //    Eratosthenes(lastNumer);
            //
            //5.Compare Char Arrays
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            CompareLexicographically(firstStr, secondStr);
        }
    }

}
