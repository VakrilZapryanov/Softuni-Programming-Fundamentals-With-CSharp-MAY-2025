﻿namespace _01.CountRealNumbers;
class Program
{
    static void Main(string[] args)
    {
        //Input
        double[] numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        //Action
        SortedDictionary<double, int> counts = new();
        foreach (int number in numbers)
        {
            if (!counts.ContainsKey(number))
            {
                counts.Add(number, 0);
            }
            counts[number]++;
        }

        //Output
        foreach ((double number, int count) in counts)
        {
            Console.WriteLine($"{number} -> {count}");
        }
    }
}

