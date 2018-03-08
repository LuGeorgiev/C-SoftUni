using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nov17Cache
{
    class Cache
    {
        static void Main(string[] args)
        {
            string keyPattern = @"([^\s->\|]+) -> ([0-9]+) \| ([^ ->\|]+)";
            var setsList = new List<DataSets>();
            var cacheData = new Dictionary<string, List<DataKey>>();
            var rgx = new Regex(keyPattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input== "thetinggoesskrra")
                {
                    break;
                }

                int validDataSet = input.IndexOf("-");
                if (validDataSet<0) 
                {
                    //this is DataSset
                    setsList.Add(new DataSets(input));
                }
                else
                {
                    //this is key array
                    var match = rgx.Match(input);
                    bool addedToDataSet = false;
                    foreach (var dataSet in setsList)
                    {
                        bool dataSetExist = dataSet.Name==match.Groups[3].Value;
                        if (dataSetExist)
                        {
                            //add dataKey if DataSet exist
                            dataSet.KeysList.Add(new DataKey(match.Groups[1].Value,
                                int.Parse( match.Groups[2].Value)));
                            addedToDataSet = true;
                            break;
                        }                        
                    }

                    if (!addedToDataSet)
                    {
                        //add to cashe
                        if (cacheData.ContainsKey(match.Groups[3].Value))
                        {
                            //if dataset Exist
                            cacheData[match.Groups[3].Value].Add(new DataKey(match.Groups[1].Value,
                                int.Parse(match.Groups[2].Value)));
                        }
                        else
                        {
                            //creat new data set
                            var newKey = new DataKey(match.Groups[1].Value,int.Parse(match.Groups[2].Value));
                            cacheData.Add(match.Groups[3].Value, new List<DataKey>());
                            cacheData[match.Groups[3].Value].Add(newKey);
                            
                        }
                    }
                }
            }

            //to Sent from cache to dataSets

            foreach (var cached in cacheData)
            {
                foreach (var set in setsList)
                {
                    if (cached.Key==set.Name)
                    {
                        set.KeysList.AddRange(cached.Value);
                    }
                }

            }

            var dataSetBySum = new Dictionary<string, long>();            

            foreach (var set in setsList)
            {
                long sum = 0;
                foreach (var key in set.KeysList)
                {
                    sum += key.Size;
                }
                dataSetBySum.Add(set.Name, sum);
            }

            if (setsList.Count==0)
            {
                return;
            }

            var sortedSet = setsList
                .OrderByDescending(x => x.KeysList.Sum(d => d.Size))
                .First();

            //var sortedSet = dataSetBySum
            //    .OrderByDescending(x => x.Value)
            //    .First();

            foreach (var dataSet in setsList.Where(x=>x.Name==sortedSet.Key))
            {
                Console.WriteLine($"Data Set: {dataSet.Name}, Total Size: {sortedSet.Value}");
                foreach (var item in dataSet.KeysList)
                {
                    Console.WriteLine("$."+item.Key);
                }
            }
           
        }
    }

    class DataSets
    {
        public string Name { get; set; }
        public List<DataKey> KeysList { get; set; }

        public DataSets(string name)
        {
            this.Name = name;
            this.KeysList = new List<DataKey>();

        }
    }

    class DataKey
    {
        public string Key { get; set; }
        public int Size { get; set; }

        public DataKey(string dataKey, int dataSize)
        {
            this.Key = dataKey;
            this.Size = dataSize;
        }
    }

}
