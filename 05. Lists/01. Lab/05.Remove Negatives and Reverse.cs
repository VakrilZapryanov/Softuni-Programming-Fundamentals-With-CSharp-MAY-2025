﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.RemoveNegativesAndReverse;
class Program
{
    static void Main(string[] args)
    {
        //Input
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        //Calculations
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.Remove(numbers[i]);
                i--;
            }
        }

        numbers.Reverse();

        //Output
        if (numbers.Count == 0)
            Console.WriteLine( "empty");
        else
            Console.WriteLine(string.Join(" ", numbers));
    }
}

