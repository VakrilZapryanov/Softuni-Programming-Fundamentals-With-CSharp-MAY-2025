//Input
uint firstDayYield = uint.Parse(Console.ReadLine());

//Calculations
uint currentDayYield = firstDayYield;
uint daysCount = 0;
uint workersConsumationSum = 0;

while (currentDayYield >= 100)
{
    daysCount++;
    workersConsumationSum += (currentDayYield - 26u);
    currentDayYield -= 10u;
}

if (daysCount > 0)
{
    workersConsumationSum -= 26u;
}

//Output
Console.WriteLine(daysCount);
Console.WriteLine(workersConsumationSum);