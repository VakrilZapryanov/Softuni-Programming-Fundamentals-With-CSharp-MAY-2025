//Input
int number = int.Parse(Console.ReadLine());

//Calculations
int firstInputNumber = number;

int factorielSum = 0;
while (number > 0)
{
    int factorial = 1;
    int lastDigit = number % 10;
    number /= 10;

    for (int i = 1; i <= lastDigit; i++)
    {
          factorial *= i;
    }

    factorielSum += factorial;
}

//Output
if (factorielSum == firstInputNumber) //Strong number
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}