using System;


namespace ThirdProblemTest
{
    class ThirdProblemTest
    {
        static void Main()
        {
            //string term = Console.ReadLine();                         //Mobile Operator
            //string typeTerm = Console.ReadLine();
            //string internet = Console.ReadLine();
            //int monthsForPay = int.Parse(Console.ReadLine());

            //double amount = 0.0;

            //if (term == "one")
            //{
            //    if (typeTerm == "Small")
            //        amount = 9.98;
            //    else if (typeTerm == "Middle")
            //        amount = 18.99;
            //    else if (typeTerm == "Large")
            //        amount = 25.98;
            //    else if (typeTerm == "ExtraLarge")
            //        amount = 35.99;
            //}
            //else if (term == "two")
            //{
            //    if (typeTerm == "Small")
            //        amount = 8.58;
            //    else if (typeTerm == "Middle")
            //        amount = 17.09;
            //    else if (typeTerm == "Large")
            //        amount = 23.59;
            //    else if (typeTerm == "ExtraLarge")
            //        amount = 31.79;
            //}

            //if (internet=="yes")
            //{
            //    if (amount <= 10)
            //        amount += 5.5;
            //    else if (amount > 10 && amount <= 30)
            //        amount += 4.35;
            //    else if (30 < amount)
            //        amount += 3.85;              

            //}
            //if (term == "two")
            //    amount *= 0.9625;
            //amount *= monthsForPay;
            //Console.WriteLine("{0:f2} lv.",amount);

            //int quantity = int.Parse(Console.ReadLine());                   // PICTURES FOR PRINT
            //string type = Console.ReadLine();
            //string order = Console.ReadLine();
            //double sum = 0.0;
            //if (type == "9X13")
            //{
            //    if (quantity>=50)
            //    {
            //        sum = 0.16 * quantity * 0.95;
            //    }
            //    else
            //    {
            //        sum = 0.16 * quantity;
            //    }
            //}
            //else if (type == "10X15")
            //{
            //    if (quantity >= 80)
            //    {
            //        sum = 0.16 * quantity * 0.97;
            //    }
            //    else
            //    {
            //        sum = 0.16 * quantity;
            //    }
            //}
            //else if (type == "13X18")
            //{
            //    if (quantity >= 50&&quantity<=100)
            //    {
            //        sum = 0.38 * quantity * 0.97;
            //    }
            //    else if(quantity>100)
            //    {
            //        sum = 0.38 * quantity*0.95;
            //    }
            //    else
            //    {
            //        sum = 0.38 * quantity;
            //    }
            //}
            //else if (type == "20X30")
            //{
            //    if (quantity >= 10&&quantity<=50)
            //    {
            //        sum = 2.90 * quantity * 0.93;
            //    }
            //    else if(quantity>50)
            //    {
            //        sum = 2.90 * quantity * 0.91;
            //    }
            //    else
            //    {
            //        sum = 2.90 * quantity;
            //    }
            //}

            //if (order=="online")
            //{
            //    sum *= 0.98;
            //}
            //Console.WriteLine("{0:f2}BGN",sum);

            //string fruit = Console.ReadLine();                          //Coctails
            //string size = Console.ReadLine();
            //int quantity = int.Parse(Console.ReadLine());
            //double sum = 0.0;

            //if (size=="small")
            //{
            //    if (fruit == "Watermelon")
            //        sum = quantity * 2 * 56;
            //    else if (fruit == "Mango")
            //        sum = quantity * 2 * 36.66;
            //    else if (fruit == "Pineapple")
            //        sum = quantity * 2 * 42.10;
            //    else if (fruit == "Raspberry")
            //        sum = quantity * 2 * 20;
            //}
            //else if (size == "big")
            //{
            //    if (fruit == "Watermelon")
            //        sum = quantity * 5 * 28.70;
            //    else if (fruit == "Mango")
            //        sum = quantity * 5 * 19.60;
            //    else if (fruit == "Pineapple")
            //        sum = quantity * 5 * 24.80;
            //    else if (fruit == "Raspberry")
            //        sum = quantity * 5 * 15.20;
            //}

            //if (sum > 1000)
            //    sum *= 0.5;
            //else if (400 <= sum && sum <= 1000)
            //    sum *= 0.85;

            //Console.WriteLine("{0:f2} lv.",sum);


            //int members = int.Parse(Console.ReadLine());
            //double points = double.Parse(Console.ReadLine());
            //string season = Console.ReadLine();                               //Final Contest
            //string place = Console.ReadLine();

            //double sum = members * points;
            //if (place == "Abroad")
            //    sum *= 1.5;

            //if (place == "Abroad")
            //{
            //    if (season == "summer")
            //        sum *= 0.90;
            //    else if (season == "winter")
            //        sum *= 0.85;
            //}
            //else if (place == "Bulgaria")
            //{
            //    if (season == "summer")
            //        sum *= 0.95;
            //    else if (season == "winter")
            //        sum *= 0.92;
            //}
            //Console.WriteLine("Charity - {0:f2}", (sum * 0.75));
            //sum *= 0.25 / members;
            //Console.WriteLine("Money per dancer - {0:f2}", sum);

            string season = Console.ReadLine();                               
            string groupType = Console.ReadLine();
            int members = int.Parse(Console.ReadLine());                       //School Camp
            int days = int.Parse(Console.ReadLine());

            double sum = members*days;
            string sport = null;

            if (groupType=="boys")
            {
                if (season == "Winter")
                {
                    sum *= 9.6;
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    sum *= 7.2;
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    sum *= 15;
                    sport = "Football";
                }
            }
            else if (groupType == "girls")
            {
                if (season == "Winter")
                {
                    sum *= 9.6;
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    sum *= 7.2;
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    sum *= 15;
                    sport = "Volleyball";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    sum *= 10;
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    sum *= 9.5;
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    sum *= 20;
                    sport = "Swimming";
                }
            }

            if (10 <= members && members < 20)
                sum *= 0.95;
            else if (20 <= members && members < 50)
                sum *= 0.85;
            else if (members >= 50)
                sum *= 0.5;

            Console.WriteLine("{0} {1:f2} lv.",sport,sum);
        }
    }
}
