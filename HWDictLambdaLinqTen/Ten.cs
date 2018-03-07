using System;
using System.Collections.Generic;
using System.Linq;

namespace HWDictLambdaLinqTen
{
    class Ten
    {
        //10. Сръбско Unleashed
        private static void SerbianDB()
        {
            var singersDB = new Dictionary<string, Dictionary<string, long>>();
            string newLine = Console.ReadLine();

            while (newLine!="End")
            {
                int endOfNameIndex = newLine.IndexOf('@');
                string[] nameArr = newLine.Substring(0, endOfNameIndex-1).Split(' ').ToArray();
                string[] venuArr = newLine.Substring(endOfNameIndex+1).Split(' ').ToArray();
                bool isValidInput = endOfNameIndex != -1
                    && (nameArr.Length <= 3&& nameArr.Length>0)
                    && (venuArr.Length >= 3 && venuArr.Length <= 5);
                if (isValidInput)
                {
                    string name=string.Join(" ",nameArr);
                    string venue="";
                    long income =0;
                                                                                
                    for (int i = 0; i < venuArr.Length - 2; i++)
                    {
                        venue += venuArr[i]+" ";
                    }
                    venue = venue.Trim();

                    income = long.Parse(venuArr[venuArr.Length - 2]) * long.Parse(venuArr[venuArr.Length - 1]);

                    //if (singersDB.ContainsKey(venue))
                    //{
                    //    if (singersDB[venue].ContainsKey(name))
                    //    {
                    //        singersDB[venue][name] += income;
                    //    }
                    //    else
                    //    {
                    //        singersDB[venue].Add(name, income);
                    //    }
                    //}
                    //else
                    //{
                    //    singersDB.Add(venue, new Dictionary<string, long> { { name, income } });
                    //} 

                    if (!singersDB.ContainsKey(venue))
                    {
                        singersDB.Add(venue, new Dictionary<string, long> { { name, income } });                        
                    }
                    else if (!singersDB[venue].ContainsKey(name))
                    {
                        singersDB[venue].Add(name, income);
                    }
                    else
                    {
                        singersDB[venue][name] += income;
                    }

                }
                newLine = Console.ReadLine();
            }
            PrintSerbianWinner(singersDB);
        }
        private static void PrintSerbianWinner(Dictionary<string, Dictionary<string, long>> singersDB)
        {
            foreach (var city in singersDB)
            {
                Console.WriteLine(city.Key);
                var sortedSingers = city.Value
                    .OrderByDescending(x => x.Value);
                foreach (var singer in sortedSingers)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }

            }
        }

        //11. Dragon Army
        private static void DragonArmy()
        {
            var myDragonArmy = new Dictionary<string, SortedDictionary<string, List<int> >> ();

            int dragonsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < dragonsNumber; i++)
            {
                string[] nextDragonStats = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dragonType = nextDragonStats[0];
                string dragonName = nextDragonStats[1];
                int dragonDmg = nextDragonStats[2]== "null" ? 45 : int.Parse(nextDragonStats[2]);
                int dragonHealth = nextDragonStats[3] == "null" ? 250 : int.Parse(nextDragonStats[3]);
                int dragonArmour = nextDragonStats[4] == "null" ? 10 : int.Parse(nextDragonStats[4]);

                if (myDragonArmy.ContainsKey(dragonType))
                {
                    if (myDragonArmy[dragonType].ContainsKey(dragonName))
                    {
                        myDragonArmy[dragonType][dragonName][0] = dragonDmg;
                        myDragonArmy[dragonType][dragonName][1] = dragonHealth;
                        myDragonArmy[dragonType][dragonName][2] = dragonArmour;
                    }
                    else
                    {
                        myDragonArmy[dragonType]
                            .Add(dragonName,new List<int> { dragonDmg, dragonHealth, dragonArmour } );
                    }
                }
                else
                {
                    myDragonArmy.
                        Add(dragonType,new SortedDictionary<string, 
                        List<int>> { { dragonName, new List<int> { dragonDmg, dragonHealth, dragonArmour } } });
                }
            }
            var typeAvgStats = new Dictionary<string, double[]>();

            int dragonsPerType = 0;
            double dmgPerType = 0;
            double healthPerType = 0;
            double armourPerType = 0;
            foreach (var type in myDragonArmy)
            {
                foreach (var dragon in type.Value)
                {
                    dragonsPerType ++;
                    dmgPerType += dragon.Value[0];
                    healthPerType += dragon.Value[1];
                    armourPerType += dragon.Value[2];
                }
                dmgPerType /= (double)dragonsPerType;
                healthPerType /= (double)dragonsPerType;
                armourPerType /= (double)dragonsPerType;

                typeAvgStats.Add(type.Key, new double[]{ dmgPerType, healthPerType, armourPerType });

                dmgPerType =0;
                healthPerType = 0;
                armourPerType = 0;
                dragonsPerType = 0;
            }

            //PRINT Dragons' stats
            foreach (var type in myDragonArmy)
            {
                Console.WriteLine($"{type.Key}::({typeAvgStats[type.Key][0]:F2}/{typeAvgStats[type.Key][1]:F2}/{typeAvgStats[type.Key][2]:F2})");
                foreach (var dragon in type.Value)
                {
                    Console.Write("-"+dragon.Key + " -> damage: ");
                    Console.Write(dragon.Value[0] +", health: ");
                    Console.Write(dragon.Value[1] +", armor: ");
                    Console.Write(dragon.Value[2]);
                    Console.WriteLine();
                }                
            }
        }

        static void Main()
        {
            //10. Сръбско Unleashed
            SerbianDB();

            //11. Dragon Army
            //DragonArmy();
        }

    }
}
