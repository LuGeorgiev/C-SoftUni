using System;
using System.Collections.Generic;
using System.Linq;

namespace Jan18Snowmen
{
    class Snowmen
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            var toRemove = new List<bool>();

            for (int i = 0; i < input.Count; i++)
            {
                toRemove.Add(true);
            }

            while (true)
            {
                

                for (int i = 0; i < input.Count; i++)
                {
                    if (toRemove[i])
                    {
                        int attackIndex = i;
                        int targetIndex = input[i] > input.Count - 1
                            ? input[i] % input.Count
                            : input[i];
                        int difference = Math.Abs(attackIndex - targetIndex);

                        if (attackIndex== targetIndex)
                        {
                            Console.WriteLine($"{i} performed harakiri");
                            toRemove[i] = false;
                        }
                        else if(difference%2==0)
                        {
                            Console.WriteLine($"{attackIndex} x {targetIndex} -> {attackIndex} wins");
                            toRemove[targetIndex] = false;
                        }
                        else
                        {
                            Console.WriteLine($"{attackIndex} x {targetIndex} -> {targetIndex} wins");
                            toRemove[attackIndex] = false;
                        }

                        int trueCount = 0;
                        foreach (var item in toRemove)
                        {
                            if (item==true)
                            {
                                trueCount++;
                            }
                        }
                        if (trueCount==1)
                        {
                            return;
                        }
                    }
                }

                for (int i = toRemove.Count-1; i >=0; i--)
                {
                    if (!toRemove[i])
                    {
                        toRemove.RemoveAt(i);
                        input.RemoveAt(i);
                    }
                }                             
                
            }
        }
    }
}
