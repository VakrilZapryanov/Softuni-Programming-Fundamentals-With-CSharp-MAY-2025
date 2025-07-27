using System;
using System.Collections.Generic;

namespace _06.ListManipulationBasics;
class Program
{
    static void Main(string[] args)
    {
        //Input
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        //Action
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input
                .Split()
                .ToArray();

            string command = arguments[0];
            switch (command)
            {
                case "Add":
                    numbers.Add(int.Parse(arguments[1]));
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(arguments[1]));
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(arguments[1]));
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                    break;
            }
        }

        //Output
        Console.WriteLine(string.Join(" ", numbers));
    }
}
