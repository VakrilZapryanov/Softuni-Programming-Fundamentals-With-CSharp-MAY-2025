using System;

int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int elementsSum = default;
bool areIdentical = true;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areIdentical = false;
        break;
    }

    elementsSum += firstArray[i];
}

if (areIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {elementsSum}");
}
