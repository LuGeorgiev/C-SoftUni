using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Third
{
    //Check is AD is key sensitive
    class Third
    {
        static List<Planet> listPlanets = new List<Planet>();

        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string encrypredPlanet = Console.ReadLine();
                int decryptCounre = 0;
                foreach (var s in encrypredPlanet)
                {
                    if (s=='s'||s=='S'|| s == 't' || s == 'T' || s == 'a' || s == 'A' ||
                        s == 'r' || s == 'R')
                    {
                        decryptCounre++;
                    }
                }

                var msgTodecrypt = new StringBuilder();
                foreach (var s in encrypredPlanet)
                {
                    msgTodecrypt.Append((char)(s - decryptCounre));
                }

                var dataForPlanet = msgTodecrypt.ToString();
                DecodePlanetInfo(dataForPlanet);

            }

            var numOfAttacked = listPlanets
                .Where(x => x.AttackOrDestroy == true)
                .Count();
            var numDestoryedPlanet = listPlanets.Count - numOfAttacked;

            var sortedAttacked = listPlanets
                .Where(x => x.AttackOrDestroy == true)
                .OrderBy(x => x.Name)
                .ToList();
            var sortedDestroyed = listPlanets
                .Where(x => x.AttackOrDestroy == false)
                .OrderBy(x => x.Name)
                .ToList();


            Console.WriteLine($"Attacked planets: {numOfAttacked}");
            if (sortedAttacked.Count>0)
            {
                foreach (var planet in sortedAttacked)
                {
                    Console.WriteLine($"-> {planet.Name}");
                }
            }

            Console.WriteLine($"Destroyed planets: {numDestoryedPlanet}");
            if (sortedDestroyed.Count > 0)
            {
                foreach (var planet in sortedDestroyed)
                {
                    Console.WriteLine($"-> {planet.Name}");
                }
            }


        }

        private static void DecodePlanetInfo(string dataForPlanet)
        {
            string pattern = @"[^@\-!:>]*@([a-zA-Z]+)[^@\-!:>]*:([0-9]+)[^@\-!:>]*!([adAD])![^@\-!:>]*->([0-9]+).*";
            var rgx = new Regex(pattern);

            var match = rgx.Match(dataForPlanet);

            if (match.Groups[1].Success&& match.Groups[2].Success&&match.Groups[3].Success&&match.Groups[4].Success)
            {
                string planetName = match.Groups[1].Value;                
                long population = long.Parse(match.Groups[2].Value);
                bool attackType = match.Groups[3].Value.ToUpper() == "A" ?true:false;
                long soldierCount = long.Parse(match.Groups[4].Value);

                listPlanets.Add(new Planet(planetName,population,attackType,soldierCount));
            }
            else
            {
                return;
            }
        }
    }
    public class Planet
    {
        public string  Name { get; set; }
        public long Population { get; set; }
        public bool AttackOrDestroy { get; set; }
        public long SoldierCount { get; set; }

        public Planet(string name, long population, bool ifAttackTrue,long soldCount)
        {
            this.Name = name;
            this.Population = population;
            this.AttackOrDestroy = ifAttackTrue;
            this.SoldierCount = soldCount;
        }
    }
}
