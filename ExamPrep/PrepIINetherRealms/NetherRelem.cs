using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepIINetherRealms
{
    class NetherRelem
    {
        static void Main()
        {
            var demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var demonsHealth = new SortedDictionary<string, double>();
            var demonsDamages = new SortedDictionary<string, double>();
            string pattern = @"-?\d+\.?\d*";
            var rgx = new Regex(pattern);

            foreach (var demon in demons)
            {
                var health = demon.
                    Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                    .Sum(s => s);
                demonsHealth[demon] = health;

                double damage = 0;

                var matches = rgx.Matches(demon);
                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol=='*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }
                demonsDamages[demon] = damage;
            }

            foreach (var demon in demonsHealth)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value} health, {demonsDamages[demon.Key]:F2} damage");
            }

            
        }
    }
}
