using System;


namespace _1to100WithWords
{
    class Program
    {
        static void Main()
        {
                     
            int num = int.Parse(Console.ReadLine());

            if (num==0)            
                Console.WriteLine("zero");
            else if(num<0||num>100)
                Console.WriteLine("invalid number");
            else if (num==100)
                Console.WriteLine("one hundred");
            else 
            {
                int ten = num / 10;
                int one = num % 10;

                if (ten==1)
                {
                    switch (one)
                    { 
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1: 
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        Console.WriteLine("thirteen");
                        break;
                    case 4:
                        Console.WriteLine("fourteen");
                        break;
                    case 5:
                        Console.WriteLine("fifteen");
                        break;
                    case 6:
                        Console.WriteLine("sixteen");
                        break;
                    case 7:
                        Console.WriteLine("seventeen");
                        break;
                    case 8:
                        Console.WriteLine("eighteen");
                        break;              
                                                                     
                     default:
                        Console.WriteLine("nineteen");
                        break;
                    }

                }
                else
                {
                    string tens = null;
                    string ones = null;


                        if (ten == 2)  tens = "twenty";                         
                        if(ten==3) tens = "thirty"; 
                        if(ten== 4) tens = "forty";
                        if(ten== 5) tens = "fifty"; 
                        if(ten== 6) tens = "sixty"; 
                        if(ten== 7) tens = "seventy";
                        if(ten== 8) tens = "eighty";
                        if(ten== 9) tens = "ninety"; 
                                                                 
                        if(one== 1) ones = "one"; 
                        if(one== 2) ones = "two"; 
                        if(one== 3) ones = "three";
                        if(one== 4) ones = "four";
                        if(one==5) ones = "five"; 
                        if(one== 6) ones = "six"; 
                        if(one== 7) ones = "seven"; 
                        if(one== 8) ones = "eight"; 
                        if(one== 9) ones = "nine";

                    if (tens==null)
                    {
                        Console.WriteLine(ones);
                    }
                    else if (ones==null)
                    {
                        Console.WriteLine(tens);
                    }
                    else
                    Console.WriteLine(tens+" "+ones);
                }
                
            }

            
        }
    }
}
