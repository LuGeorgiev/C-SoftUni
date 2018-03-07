using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {

            string[] args = command
                .Split(ArgumentsDelimiter)
                .ToArray();

            if (args[0] == "rshift")
            {
                array = ArrayShiftRight(array);
            }
            else if(args[0] == "lshift")
            {
                array = ArrayShiftLeft(array);
            }
            else
            {
                string action = args[0];
                int index = int.Parse(args[1])-1;
                int value = int.Parse(args[2]);

                array = PerformAction(array, action, index, value);
            }
                      

            PrintArray(array);
            //Console.WriteLine('\n');
            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int index, int value)
    {
       
        switch (action)
        {
            case "multiply":
                arr[index] *= value;
                break;
            case "add":
                arr[index] += value;
                break;
            case "subtract":
                arr[index] -= value;
                break;            
        }
        return arr;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1]=temp;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
    }
}
