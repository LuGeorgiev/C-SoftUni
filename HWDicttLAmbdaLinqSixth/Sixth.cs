using System;
using System.Collections.Generic;
using System.Linq;

namespace HWDicttLAmbdaLinqSixth
{
    class Sixth
    {
        //6 User Logs
        private static void UserLogs()
        {
            var userIPLog = new SortedDictionary<string,Dictionary<string,int>>();

            string msg = Console.ReadLine();
            while (msg!="end")
            {
                int indexIP = msg.IndexOf(' ');
                string ipAddress = msg.Substring(3, indexIP-2);
                int indexUser = msg.IndexOf("user=");
                string user = msg.Substring(indexUser+5);
                if (userIPLog.ContainsKey(user))
                {
                    //add IP to existing user
                    if (userIPLog[user].ContainsKey(ipAddress))
                    {
                        userIPLog[user][ipAddress]++;
                    }
                    else
                    {
                        userIPLog[user].Add(ipAddress, 1);
                    }
                }
                else
                {
                    //add user and IP
                                    //userIPLog.Add(user, new Dictionary<string, int>()); //second way to add
                                    //userIPLog[user].Add(ipAddress, 1);
                    userIPLog.Add(user, new Dictionary<string, int>() { { ipAddress, 1 } });
                }

                msg = Console.ReadLine();
            }
            foreach (var user in userIPLog)
            {
                Console.WriteLine(user.Key+":");
                int counter = 0;
                foreach (var pair in user.Value)
                {
                    if (counter!=0)
                    {
                        Console.Write(", ");
                    }  
                    Console.Write($"{pair.Key}=> {pair.Value}");
                    counter++;
                }
                Console.Write(".");
                Console.WriteLine();
            }
        }

        //7 Population Counter NOT FINISHED
        private static void PopulationDB()
        {
            var popDB = new Dictionary<string, Dictionary<string, int>> ();
            string[] newEntry = Console.ReadLine().Split('|').ToArray();

            while (newEntry[0] !="report")
            {
                string country = newEntry[1];
                string city = newEntry[0];
                int cityPopulation = int.Parse(newEntry[2]);
                if (popDB.ContainsKey(country))
                {
                    popDB[country].Add(city,cityPopulation);
                }
                else
                {
                    popDB.Add(country, new Dictionary<string, int>() { {city,cityPopulation} });
                }
                newEntry = Console.ReadLine().Split('|').ToArray();
            }

            //Dict to sort country by total polulation
            var countryByPop = new Dictionary<string,long>();

            foreach (var country in popDB)
            {
                long countryPopulation = 0;
                foreach (var city in country.Value)
                {
                    countryPopulation += city.Value;
                }
                countryByPop.Add(country.Key, countryPopulation);
                countryPopulation = 0;
            }
            //sort by total polulation
            var sortedCountry = countryByPop
                .OrderByDescending(x => x.Value);           
            
            //Print result
            foreach (var country in sortedCountry)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                var sortedCity = popDB[country.Key]
                    .OrderByDescending(x => x.Value);

                foreach (var city in sortedCity)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        //8. Logs Aggregator
        private static void LogsAgregator(int linesNumber)
        {
            var userDuration = new SortedDictionary<string, int>();
            var userIPList = new Dictionary<string, SortedSet<string>>();

            for (int i = 1; i <= linesNumber; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = command[1];
                string ip = command[0];
                int duration = int.Parse(command[2]);

                if (userDuration.ContainsKey(name))
                {
                    userDuration[name] += duration;
                    userIPList[name].Add(ip);
                }
                else
                {
                    userDuration.Add(name, duration);
                    userIPList.Add(name, new SortedSet<string> {ip});
                }
            }

            foreach (var name in userDuration)
            {
                int counter = 0;
                Console.Write($"{name.Key}: {name.Value} [");
                foreach (var item in userIPList[name.Key])
                {
                    if (counter!=0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(item);
                    counter++;
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }

        //9. Legendary Farming
        private static void LegendaryFarming()
        {
            Dictionary<string, int> heroeInventory = new Dictionary<string, int>();
            heroeInventory.Add("motes", 0);
            heroeInventory.Add("fragments", 0);
            heroeInventory.Add("shards", 0);

            int lineCounter = 0;
            bool isLegendaryFound = false;
            string[] newMaterials = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                
            while (lineCounter<=10)
            {

                for (int i = 0; i < newMaterials.Length; i+=2)
                {
                    int quantity = int.Parse(newMaterials[i]);
                    string material = newMaterials[i+1];

                    if (heroeInventory.ContainsKey(material))
                    {
                        heroeInventory[material] += quantity;                        
                    }
                    else
                    {
                        heroeInventory.Add(material, quantity);
                        
                    }

                    if ((material == "shards" || material == "fragments" || material == "motes")
                            && heroeInventory[material] > 249)
                    {
                        heroeInventory[material] -= 250;                        

                        if (material == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            isLegendaryFound = true;
                            break;
                        }
                        else if (material == "fragments")
                        {
                            isLegendaryFound = true;
                            Console.WriteLine("Valanyr obtained!");
                            break;
                        }
                        else if (material == "motes")
                        {
                            isLegendaryFound = true;
                            Console.WriteLine("Dragonwrath obtained!");
                            break;
                        }
                    }

                }
                if (isLegendaryFound)
                {
                    break;
                }
                                
                newMaterials = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                lineCounter++;
            }
            PrintHeroeInventory(heroeInventory);
        }
        private static void PrintHeroeInventory(Dictionary<string, int> inventory)
        {
            var sortedLegendary = inventory
                .OrderByDescending(x => x.Value)
                .ThenBy(x=>x.Key);
                
            foreach (var item in sortedLegendary)
            {
                if (item.Key=="motes"|| item.Key == "shards" || item.Key == "fragments")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            var sortedJunks = inventory
                .OrderBy(x => x.Key);
            foreach (var item in sortedJunks)
            {
                if (item.Key != "motes" && item.Key != "shards" && item.Key != "fragments")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }

        static void Main()
        {
            //6 User Logs
            //UserLogs();

            //7 Population Counter NOT FINISHED
            PopulationDB();

            //8. Logs Aggregator
            //LogsAgregator(int.Parse(Console.ReadLine()));

            //9. Legendary Farming
            //LegendaryFarming();
        }

    }
}
