//Input
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

//Action
for (int i = 0; i < rotations; i++)
{
    int firstNumber = numbers[0];

    int[] rotated = new int[numbers.Length];

    for (int j = 1; j < numbers.Length; j++)
    {
        rotated[j - 1] = numbers[j];
    }
    rotated[rotated.Length - 1] = firstNumber;

    numbers = rotated;
}

//Output
Console.WriteLine(string.Join(" ", numbers));
