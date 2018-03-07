using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Second
{
    class Second
    {
        static void Main()
        {
            var lenDNA = int.Parse(Console.ReadLine());
            var arrDNA = new int[lenDNA];
            string input = Console.ReadLine();

            int bestSequence = 0;
            int bestSum = 0;
            int bestStartINdex = 0;
            var bestDNA = new int[lenDNA];
            var bestSequenceIndex = 0;
            var sequenceIndex = 0; 

            while (input!= "Clone them!")
            {
                sequenceIndex++;

                int currentSequence = 1;
                int currentSum = 0;
                int curentBestStartIndex = 0;
                int currentBestSequence = 1;

                arrDNA = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < arrDNA.Length; i++)
                {
                    if (arrDNA[i]==1)
                    {
                        currentSum++;
                    }
                    if (i>0)
                    {
                        if (arrDNA[i]==arrDNA[i-1]&&arrDNA[i]==1)
                        {
                            currentSequence++;
                            if (currentSequence> currentBestSequence)
                            {
                                currentBestSequence = currentSequence;
                                curentBestStartIndex = i;
                            }
                        }
                        else
                        {
                            currentSequence = 1;
                        }
                    }
                }


                if (currentBestSequence > bestSequence)
                {
                    bestSequence = currentBestSequence;
                    bestSum = currentSum;
                    bestStartINdex = curentBestStartIndex;
                    bestSequenceIndex = sequenceIndex;

                    for (int i = 0; i < arrDNA.Length; i++)
                    {
                        bestDNA[i] = arrDNA[i];
                    }


                }
                else if (currentBestSequence == bestSequence && curentBestStartIndex < bestStartINdex)
                {
                    bestSequence = currentBestSequence;
                    bestSum = currentSum;
                    bestStartINdex = curentBestStartIndex;
                    bestSequenceIndex = sequenceIndex;

                    for (int i = 0; i < arrDNA.Length; i++)
                    {
                        bestDNA[i] = arrDNA[i];
                    }
                }
                else if (currentBestSequence == bestSequence && 
                    curentBestStartIndex == bestStartINdex&&
                    currentSum>bestSum)
                {
                    bestSequence = currentBestSequence;
                    bestSum = currentSum;
                    bestStartINdex = curentBestStartIndex;
                    bestSequenceIndex = sequenceIndex;

                    for (int i = 0; i < arrDNA.Length; i++)
                    {
                        bestDNA[i] = arrDNA[i];
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",bestDNA));
        
        }
    }
}
