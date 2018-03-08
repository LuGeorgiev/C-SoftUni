using System;

namespace Nov17Downsite
{
    class Downsite
    {
        static void Main(string[] args)
        {
            var sitesDown = int.Parse(Console.ReadLine());
            var securytyKey = int.Parse(Console.ReadLine());
            long securytyToken = (long)Math.Pow(securytyKey, sitesDown);
            decimal totalLoss = 0;
            for (int i = 0; i < sitesDown; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);
                string siteName = input[0];
                long siteVisit = long.Parse(input[1]);
                decimal pricePerVisit =decimal.Parse( input[2]);

                Console.WriteLine(siteName.Trim());

                totalLoss += siteVisit * pricePerVisit;
            }

            int n = 20;
            string format = String.Format("{{0:0.{0}}}", new string('0', n));
            Console.WriteLine("Total Loss: "+String.Format(format, totalLoss)); 
            
            Console.WriteLine("Security Token: "+securytyToken);

        }
    }
}
