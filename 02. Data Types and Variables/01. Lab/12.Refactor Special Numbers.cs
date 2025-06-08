//Input
int number = int.Parse(Console.ReadLine()); 

//Calculations
int sum = 0;
int currentDigit = 0;
bool isSpecial = false;
for (int currentNumber = 1; currentNumber <= number; currentNumber++)
{
    currentDigit = currentNumber;
    while (currentNumber > 0)
    {
        sum += currentNumber % 10;
        currentNumber = currentNumber / 10;
    }
    isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", currentDigit, isSpecial);
    sum = 0;
    currentNumber = currentDigit;
}