string input = Console.ReadLine();
string[] numbersAsString = input.Split();

for (int i = 0; i < numbersAsString.Length; i++)
{
    double currentNumber = double.Parse(numbersAsString[i]);
    int roundedNumber = (int)Math.Round(currentNumber, MidpointRounding.AwayFromZero);

    Console.WriteLine(currentNumber + " => " + roundedNumber);
}