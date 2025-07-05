//Input
int[] numbersInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

//Calculations
bool isFound = false;
for (int i = 0; i < numbersInput.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int left = 0; left < i; left++)
    {
        leftSum += numbersInput[left];
    }
    for (int right = i + 1; right < numbersInput.Length; right++)
    {
        rightSum += numbersInput[right];
    }

    if (leftSum == rightSum)
    {
        //Output
        Console.WriteLine(i);
        isFound = true;
        break;
    }
}

//Output
if (!isFound)
{
    Console.WriteLine("no");
}
