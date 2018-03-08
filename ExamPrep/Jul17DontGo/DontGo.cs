using System;
using System.Collections.Generic;
using System.Linq;

namespace Jul17DontGo
{
    class DontGo
    {
        static List<long> pokemons = new List<long>();
        static long removedElement = 0;

        static void Main()
        {
            pokemons.AddRange(Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList());

            while (pokemons.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    RemoveFirst();
                }
                else if (index > pokemons.Count - 1)
                {
                    RemoveLast();
                }
                else
                {
                    RemoveIndex(index);
                }
            }
            Console.WriteLine(removedElement);
        }

        private static void IncreaseDecrease(long increaseDecrease)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= increaseDecrease)
                {
                    pokemons[i] += increaseDecrease;
                }
                else
                {
                    pokemons[i] -= increaseDecrease;
                }
            }
        }
        private static void RemoveIndex(int index)
        {
            var currentElement = pokemons[index];
            removedElement += currentElement;
            pokemons.RemoveAt(index);
            IncreaseDecrease(currentElement);
        }

        private static void RemoveLast()
        {
            var currentElement = pokemons[pokemons.Count - 1];
            pokemons[pokemons.Count - 1] = pokemons[0];
            removedElement += currentElement;
            IncreaseDecrease(currentElement);
        }

        private static void RemoveFirst()
        {
            var currentElement = pokemons[0];
            pokemons[0] = pokemons[pokemons.Count - 1];
            removedElement += currentElement;
            IncreaseDecrease(currentElement);
        }
    }
}
