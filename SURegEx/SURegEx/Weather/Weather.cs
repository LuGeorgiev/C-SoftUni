using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Weather
{
    class Weather
    {
        static void Main()
        {
            
            string text = Console.ReadLine();
            string pattern = @"([A-Z]{2})(\d{2}).(\d{0,2})([a-zA-Z]+)\|";
            var rgx = new Regex(pattern);

            var cityWeather = new List<City>();

            while (text!="end")
            {
                MatchCollection matches = Regex.Matches(text, pattern);                
                foreach (Match match in matches)
                {                   
                    double avgTemp = double.Parse(match.Groups[2].Value + "." + match.Groups[3].Value);
                    string cityName = match.Groups[1].Value;
                    string weather = match.Groups[4].Value;

                    if (!cityWeather.Any(x=>x.Name== cityName))
                    {
                        cityWeather.Add(new City(cityName, avgTemp, weather));
                    }
                    else
                    {
                        foreach (var city in cityWeather)
                        {
                            if (city.Name==cityName&&city.AvgTemp<avgTemp)
                            {
                                city.AvgTemp = avgTemp;
                                city.Weather = weather;
                            }
                        }
                    }
                }

                text = Console.ReadLine();
            }

            var sortedByAvgTemp = cityWeather
                .OrderBy(x => x.AvgTemp);
            foreach (var city in sortedByAvgTemp)
            {
                Console.WriteLine($"{city.Name} => {city.AvgTemp:f2} => {city.Weather}");
            }

        }
    }

    public class City
    {
        public string Name { get; set; }
        public double AvgTemp { get; set; }
        public string Weather { get; set; }

        public City(string name, double avgTemp, string weather)
        {
            this.Name = name;
            this.AvgTemp = avgTemp;
            this.Weather = weather;
        }
    }
}
