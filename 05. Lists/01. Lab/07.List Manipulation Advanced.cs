using System;
namespace _07.ListManipulationAdvanced;
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
        bool hasChanges = false;
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
                    hasChanges = true;
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(arguments[1]));
                    hasChanges = true;
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(arguments[1]));
                    hasChanges = true;
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                    hasChanges = true;
                    break;
                case "Contains":
                    if (numbers.Contains(int.Parse(arguments[1])))
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine("No such number");
                    break;
                case "PrintEven":
                    List<int> evenNumbers = new();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                            evenNumbers.Add(numbers[i]);
                    }

                    Console.WriteLine(string.Join(" ", evenNumbers));
                    break;
                case "PrintOdd":
                    List<int> oddNumbers = new();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                            oddNumbers.Add(numbers[i]);
                    }

                    Console.WriteLine(string.Join(" ", oddNumbers));
                    break;
                case "GetSum":
                    int sum = default;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                    break;
                case "Filter":
                    List<int> filteredNumbers = new();
                    string condition = arguments[1];

                    if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(arguments[2]))
                                filteredNumbers.Add(numbers[i]);
                        }
                    }
                    if (condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(arguments[2]))
                                filteredNumbers.Add(numbers[i]);
                        }
                    }
                    if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(arguments[2]))
                                filteredNumbers.Add(numbers[i]);
                        }
                    }
                    if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(arguments[2]))
                                filteredNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
            }
        }

        if (hasChanges)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

