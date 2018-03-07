using System;

namespace AdretisementMessage
{
    class AdvMsg
    {
        static void Main(string[] args)
        {
            int msgNumber = int.Parse(Console.ReadLine());
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] phreases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var rnd = new Random();

            for (int i = 0; i < msgNumber; i++)
            {
                string thisEvent = events[rnd.Next(events.Length-1)];
                string thisPhrase = phreases[rnd.Next(phreases.Length-1)];
                string thisAuthor = authors[rnd.Next(authors.Length-1)];
                string thisCity = cities[rnd.Next(cities.Length-1)];
                Console.WriteLine($"{thisPhrase} {thisEvent} {thisAuthor} - {thisCity}");
            }
        }
    }
}
