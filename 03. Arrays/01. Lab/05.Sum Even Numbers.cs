int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenNumbersSum = default;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) evenNumbersSum += numbers[i];
}

Console.WriteLine(evenNumbersSum);
