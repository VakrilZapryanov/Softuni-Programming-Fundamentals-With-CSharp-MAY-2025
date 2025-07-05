//Input
int n = int.Parse(Console.ReadLine());

//Action
int[] firstArr = new int[n];
int[] secondArr = new int[n];

for (int i = 0; i < n; i++)
{
    int[] numbersInput = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArr[i] = numbersInput[0];
        secondArr[i] = numbersInput[1];
    }
    else
    {
        firstArr[i] = numbersInput[1];
        secondArr[i] = numbersInput[0];
    }
}

//Output
Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));
