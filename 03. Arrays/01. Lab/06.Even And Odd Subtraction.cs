int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenNumbersSum = default;
int oddNumbersSum = default;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbersSum += numbers[i];
    }
    else 
    {
        oddNumbersSum += numbers[i];
    }
}

int difference = evenNumbersSum - oddNumbersSum;

Console.WriteLine(difference);