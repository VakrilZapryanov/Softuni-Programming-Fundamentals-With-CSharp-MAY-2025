//Input
int input = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
while (input > 0)
{
    int currentDigit = input % 10;
    input /= 10;

    sum += currentDigit;
}

//Output
Console.WriteLine(sum);