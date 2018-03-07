using System;
using System.Linq;
using System.Collections.Generic;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var lenTwo = text
                .Split(' ')
                .Where(x => x.Length == 2);
            var reversedItems = new List<uint>();
            foreach (var item in lenTwo)
            {
                var reversedToBe = item.ToCharArray().Reverse();
                string reversed = string.Join("", reversedToBe);
                var revInt = Convert.ToUInt32(reversed, 16);
                reversedItems.Add(revInt);
                
            }
            reversedItems.Reverse();
            foreach (var item in reversedItems)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}
