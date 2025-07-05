//Input
int[] numbersInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

//Action
int bestLength = 0, bestNumber = 0;

for (int i = 0; i < numbersInput.Length; i++)
{
    int currentLength = 1;

    for (int j = i + 1; j < numbersInput.Length; j++)
    {
        if (numbersInput[i] == numbersInput[j])
        {
            currentLength++;
        }
        else
        {
            break;
        }
    }
    if (currentLength > bestLength)
    {
        bestLength = currentLength;
        bestNumber = numbersInput[i];
    }
}

//Outpu
for (int i = 1; i <= bestLength; i++)
{
    Console.Write(bestNumber + " ");
}
