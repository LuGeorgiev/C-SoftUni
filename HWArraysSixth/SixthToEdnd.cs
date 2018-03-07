using System;
using System.Linq;
using System.Collections.Generic;

namespace HWArraysSixth
{
    class SixthToEdnd
    {
        //6.	Max Sequence of Equal Elements
        static void MaxEqualSequence(int[] arr)
        {
            int countOccurency = 0;
            int longestOccurency = 0;
            int lastIndexOfLongest = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    countOccurency++;
                    if (longestOccurency < countOccurency)
                    {
                        longestOccurency = countOccurency;
                        lastIndexOfLongest = i;
                    }
                }
                else
                {
                    countOccurency = 0;
                }
            }

            for (int i = lastIndexOfLongest- longestOccurency+1; i <= lastIndexOfLongest+1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        //7.	Max Sequence of Increasing Elements
        static void MaxIncreasingSequence(int[] arr)
        {
            int countOccurency = 0;
            int longestOccurency = 0;
            int lastIndexOfLongest = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    countOccurency++;
                    if (longestOccurency < countOccurency)
                    {
                        longestOccurency = countOccurency;
                        lastIndexOfLongest = i;
                    }
                }
                else
                {
                    countOccurency = 0;
                }
            }

            for (int i = lastIndexOfLongest - longestOccurency + 1; i <= lastIndexOfLongest + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //8.	Most Frequent Number
        static void MosrFrequenNumber(int[] arr)
        {
            var mostFrequentNumber = new Dictionary<int, int>(65535);
            int keyOfBiggestValue = 0;
            var biggestValue = 1;
            foreach (var num in arr)
            {
                if (mostFrequentNumber.ContainsKey(num))
                {
                    mostFrequentNumber[num]++;
                    if (mostFrequentNumber[num] > biggestValue)
                    {
                        keyOfBiggestValue = num;
                        biggestValue = mostFrequentNumber[num];
                    }
                }
                else
                {
                    mostFrequentNumber.Add(num, 1);
                }
            }
            if (biggestValue > 1)
            {
                Console.WriteLine(keyOfBiggestValue);
            }
            else
            {

                Console.WriteLine(arr[0]);
            }
        }
        //9.	Index of Letters
        static void IndexToLetters(string word)
        {
            char[] letters = word.ToCharArray();
            foreach (char letter in letters)
            {
                Console.WriteLine(Convert.ToChar(letter) + " -> " + (letter - 97));
            }
        }
        //10.	Pairs by Difference
        private static void PairDifference(int[] arr, int difference)
        {
            int pairCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i]-arr[j])==difference)
                    {
                        pairCount++;
                    }
                }
            }
            Console.WriteLine(pairCount);
        }
        //11.	Equal Sums
        private static void EqualSums(int[] arr)
        {
         
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j <= i-1; j++)
                {
                    leftSum += arr[j];
                }
                for (int k = i+1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
         
        }       

        static void Main(string[] args)
        {
            //6.Max Sequence of Equal Elements
            //int[] maxSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //MaxEqualSequence(maxSequence);

            //7.Max Sequence of Increasing Elements     //(input from 6)
            //MaxIncreasingSequence(maxSequence);

            //8.Most Frequent Number //(input from 6)
            //MosrFrequenNumber(maxSequence);

            //9.	Index of Letters
            //string word = Console.ReadLine();
            //IndexToLetters(word);

            //10.Pairs by Difference
            //int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int difference = int.Parse(Console.ReadLine());
            //PairDifference(intArray, difference);

            //11.Equal Sums  
            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            EqualSums(intArray);
        }

    }
}
