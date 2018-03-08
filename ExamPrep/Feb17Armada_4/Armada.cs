using System;
using System.Collections.Generic;
using System.Linq;

namespace Feb17Armada_4
{
    class Armada
    {
        static void Main()
        {
            var legions = new List<Legion>();
            var inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                var nextEntry = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var lstActivity = int.Parse(nextEntry[0]);
                var legionName = nextEntry[1];
                var soldierType = nextEntry[2];
                var soldierCount = int.Parse(nextEntry[3]);

                //add non existing legion
                bool isLegioExist = false; 
                foreach (var legionEntry in legions)
                {
                    if (legionEntry.Name==legionName)
                    {
                        isLegioExist = true;
                    }
                }
                if (!isLegioExist)
                {
                    //if legion do not exist
                    legions.Add(new Legion(legionName, lstActivity, soldierType, soldierCount));
                }
                else
                {
                    //legion is existing check foor existing soldier
                    bool isSoldierTypeExist = false;
                    foreach (var legionEntry in legions)
                    {
                        if (legionEntry.Name == legionName)
                        {
                            if (legionEntry.LastActivity<lstActivity)
                            {
                                //update activity if it is higher
                                legionEntry.LastActivity = lstActivity;
                            }
                            foreach (var soldier in legionEntry.Soldiers)
                            {
                                if (soldier.SoldType==soldierType)
                                {
                                    //then update count and break
                                    soldier.Count += soldierCount;
                                    isSoldierTypeExist = true;
                                    break;
                                }
                            }
                            if (!isSoldierTypeExist)
                            {
                                //soldier type do not exist
                                legionEntry.Soldiers.Add(new Soldier(soldierType,soldierCount));
                            }
                        }
                        if (isSoldierTypeExist)
                        {
                            //soldiertype was added
                            break;
                        }
                    }

                }

                //if (!legions.Any(x=>x.Name==legionName))
                //{
                //    //create Legion
                //    legions.Add(new Legion(legionName,lstActivity,soldierType, soldierCount));
                //}
                //else
                //{
                //    //add or update Soldiers to existing legion
                //    foreach (var legion in legions)
                //    {
                //        if (legion.Name==legionName)
                //        {
                //            if (!legion.Soldiers.Any(x=>x.SoldType==soldierType))
                //            {
                //                //type do not exist
                //                legion.Soldiers.Add(new Soldier(soldierType,soldierCount));
                //                if (legion.LastActivity<lstActivity)
                //                {
                //                    legion.LastActivity = lstActivity;
                //                }
                //            }
                //            else
                //            {
                //                //update existing soldier
                //                foreach (var soldir in legion.Soldiers)
                //                {
                //                    if (soldir.SoldType==soldierType)
                //                    {
                //                        soldir.Count += soldierCount;
                //                        if (legion.LastActivity < lstActivity)
                //                        {
                //                            legion.LastActivity = lstActivity;
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
            }
            var command = Console.ReadLine()
                .Split('\\')
                .ToList();
            if (command.Count==2)
            {
                var lastAct = int.Parse(command[0]);
                var soldier = command[1];
                                
                var filteredLegions = legions
                    .Where(x => x.LastActivity < lastAct);
                //initialize new property in class
                foreach (var legion in filteredLegions)
                {
                    foreach (var sold in legion.Soldiers)
                    {
                        if (sold.SoldType== soldier)
                        {
                            legion.SoldiersOfGivenType = sold.Count;
                        }                        
                    }                    
                }

                var sortedLegions = filteredLegions
                    .Where(x => x.SoldiersOfGivenType > long.MinValue)
                    .OrderByDescending(y => y.SoldiersOfGivenType);

                foreach (var item in sortedLegions)
                {
                    Console.Write($"{item.Name} -> ");
                    foreach (var kamikadze in item.Soldiers)
                    {
                        if (kamikadze.SoldType== soldier)
                        {
                            Console.Write(kamikadze.Count);
                        }
                    }
                        Console.WriteLine();
                }              
                
            }
            else
            {
                var soldier = command[0];
                var sortedLegions = legions
                    .OrderByDescending(x => x.LastActivity);

                foreach (var legion in sortedLegions)
                {
                    foreach (var kamikadze in legion.Soldiers)
                    {
                        if (kamikadze.SoldType== soldier)
                        {
                            Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
                        }
                    }

                }
            }

        }
    }

    public class Legion
    {
        public string Name { get; set; }
        public int LastActivity { get; set; }
        public List<Soldier> Soldiers { get; set; }
        public long SoldiersOfGivenType { get; set; } = long.MinValue;

        public Legion(string name, int activity, string soldierType, long soldierCount)
        {
            this.Name = name;
            this.LastActivity = activity;
            this.Soldiers = new List<Soldier>()
            {
                new Soldier ( soldierType,  soldierCount )
            };
        }
    }

    public class Soldier
    {
        public string SoldType { get; set; }
        public long Count { get; set; }

        public Soldier(string type, long count)
        {
            this.Count = count;
            this.SoldType = type;
        }
    }
}
