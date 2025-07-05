//Input
string[] firstArray = Console.ReadLine()
    .Split()
    .ToArray();

string[] secondArray = Console.ReadLine()
    .Split()
    .ToArray();

//Action
for (int i = 0; i < secondArray.Length; i++)
{
    string currentElementFromSecondString = secondArray[i];

    for (int j = 0; j < firstArray.Length; j++)
    {
        string currentElementFromFirstString = firstArray[j];

        if (currentElementFromFirstString == currentElementFromSecondString)
        {
            //Output
            Console.Write(currentElementFromFirstString + " ");
        }
    }
}
