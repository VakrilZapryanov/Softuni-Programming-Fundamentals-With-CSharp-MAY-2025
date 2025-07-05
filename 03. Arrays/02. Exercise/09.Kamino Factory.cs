//Input
int dnaLength  = int.Parse(Console.ReadLine());

//Action
int bestSum = 0;
int[] bestDna = new int[dnaLength];
int currentSampleNumber = 0;
int bestSampleNumber = 0;
int bestSubsequenceLength = 0;
int bestStartIndex = int.MaxValue;

string command = string.Empty;
while((command = Console.ReadLine()) != "Clone them!")
{
    int[] currentDna = command
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    
    currentSampleNumber++;

    int currentSum = 0;
    for (int i = 0; i < currentDna.Length; i++)
    {
        currentSum += currentDna[i];
    }

    //Finding the longest sequence of ones
    int currentLength = 0;
    int currentBestLength = 0;
    int currentStartIndex = -1;
    for (int i = 0; i < currentDna.Length; i++)
    {
        if (currentDna[i] == 1)
        {
            currentLength++;
            if (currentLength > currentBestLength)
            {
                currentBestLength = currentLength;
                currentStartIndex = i - currentLength + 1;
            }
        }
        else
        {
            currentLength = 0;
        }
    }

    //Finding the best DNA
    bool isBetter = false;
    if (currentBestLength > bestSubsequenceLength)
    {
        isBetter = true;
    }
    else if (currentBestLength == bestSubsequenceLength)
    {
        if (currentStartIndex < bestStartIndex)
        {
            isBetter = true;
        }
        else if (currentStartIndex == bestStartIndex)
        {
            if (currentSum > bestSum)
            {
                isBetter = true;
            }
        }
    }

    if (isBetter)
    {
        bestSampleNumber = currentSampleNumber;
        bestSum = currentSum;
        bestDna = currentDna;
        bestStartIndex = currentStartIndex;
        bestSubsequenceLength = currentBestLength;
    }
}

//Output
Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestDna));
