using System;
using System.Linq;

namespace CharacterMultply
{
    class CharMultiply
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();
            string first = input.Split(' ').First();
            string second = input.Split(' ').Last();
            MultyplyStrings(first, second);
        }

        private static void MultyplyStrings(string first, string second)
        {
            var longerSeq = first.Length > second.Length?
                first.ToCharArray():
                second.ToCharArray();

            var shorterSeq = first.Length <= second.Length ? 
                first.ToCharArray() : 
                second.ToCharArray();

            int multiplyLen = shorterSeq.Length;
            int toAdd = longerSeq.Length- shorterSeq.Length;

            int totalSum = 0;
            for (int i = 0; i < multiplyLen; i++)
            {
                totalSum += (int)longerSeq[i] * (int)shorterSeq[i];
            }
            for (int i = multiplyLen; i < longerSeq.Length; i++)
            {
                totalSum += (int)longerSeq[i];
            }

            Console.WriteLine(totalSum);
            
        }
    }
}
