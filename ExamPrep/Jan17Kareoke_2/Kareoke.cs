using System;
using System.Linq;
using System.Collections.Generic;

namespace Jan17Kareoke_2
{
    class Kareoke
    {
        static void Main()
        {
            var namesAvailable = new HashSet<string>();
            var songsAvailable = new HashSet<string>();

            var inputNames = Console.ReadLine()
                .Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToArray();
            foreach (var name in inputNames)
            {

                namesAvailable.Add(name);
            }
            var inputSongs = Console.ReadLine()
               .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => x.Trim())
               .ToArray();
            foreach (var name in inputSongs)
            {

                songsAvailable.Add(name);
            }

            var nameByAwards = new SortedDictionary<string, SortedSet<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input=="dawn")
                {
                    break;
                }

                var singerStats = input
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                if (singerStats.Length!=3)
                {
                    continue;
                }

                var singerName = singerStats[0];
                var singerSong = singerStats[1];
                var singerAward = singerStats[2];

                bool isNameValid = namesAvailable.Contains(singerName);
                bool isSongValid = songsAvailable.Contains(singerSong);

                if (isNameValid && isSongValid)
                {
                    bool isNameExisting = nameByAwards.ContainsKey(singerName);

                    if (isNameExisting)
                    {
                        //add award
                        bool isAwardExisting = nameByAwards[singerName].Contains(singerAward);
                        if (!isAwardExisting)
                        {
                            nameByAwards[singerName].Add(singerAward);
                        }

                    }
                    else
                    {
                        //creat singer and award
                        nameByAwards.Add(singerName, new SortedSet<string>());
                        nameByAwards[singerName].Add(singerAward);
                    }
                }
            }

            if (nameByAwards.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var sortedSingers = nameByAwards
                .OrderByDescending(x => x.Value.Count);

            foreach (var singer in sortedSingers)
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                foreach (var award in singer.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }
                
        }
    }
}
