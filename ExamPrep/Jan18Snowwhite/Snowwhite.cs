using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Jan18Snowwhite
{
    class Snowwhite
    {
        static void Main()
        {
            //•	If all sorting criteria fail, the order should be by order of input. HOW TO SOLVE

            var dwarvesList = new List<Dwarf>();
            var rgx = new Regex(@"([^ <>:]+)\s<:>\s([^ <>:]+)\s<:>\s([0-9]+)");
            string nextDwarf = Console.ReadLine();

            var match = rgx.Match(nextDwarf);
            string dwarfName = match.Groups[1].Value;
            string dwarfHatCol = match.Groups[2].Value;
            decimal dwarfStrength = decimal.Parse(match.Groups[3].Value);
            //Add dwarf
            dwarvesList.Add(new Dwarf(dwarfName,dwarfHatCol,dwarfStrength));
            nextDwarf = Console.ReadLine();

            while (nextDwarf!= "Once upon a time")
            {
                match = rgx.Match(nextDwarf);
                dwarfName = match.Groups[1].Value;
                dwarfHatCol = match.Groups[2].Value;
                dwarfStrength = long.Parse(match.Groups[3].Value);
                //check scenarios
                bool dwarfAdded = false;
                foreach (var dwarf in dwarvesList)
                {
                    if (dwarf.Name==dwarfName &&
                        dwarf.HatColor==dwarfHatCol)
                    {
                        if (dwarfStrength>dwarf.Physic)
                        {
                            dwarf.Physic = dwarfStrength;
                            dwarfAdded = true;
                            break;
                        }
                    }
                    else if (dwarf.Name == dwarfName &&
                        dwarf.HatColor != dwarfHatCol)
                    {
                        dwarvesList.Add(new Dwarf(dwarfName, dwarfHatCol, dwarfStrength));
                        dwarfAdded = true;
                        break;
                    }
                }
                if (!dwarfAdded)
                {
                    dwarvesList.Add(new Dwarf(dwarfName, dwarfHatCol, dwarfStrength));
                }


                nextDwarf = Console.ReadLine();
            }

            foreach (var dwarf in dwarvesList)
            {
                int sameColCount = 0;
                foreach (var dwCout in dwarvesList)
                {
                    if (dwarf.HatColor==dwCout.HatColor)
                    {
                        sameColCount++;
                    }
                }
                dwarf.SameColorHatCount = sameColCount;
            }

            var sortedDwarves = dwarvesList
                .OrderByDescending(x => x.Physic)
                .ThenByDescending(x=>x.SameColorHatCount)
                .ToList();

            foreach (var dwarf in sortedDwarves)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physic}");
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public decimal Physic { get; set; }
        public int SameColorHatCount { get; set; }

        public Dwarf(string name, string hatColor, decimal strength)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physic = strength;
        }
    }
}
