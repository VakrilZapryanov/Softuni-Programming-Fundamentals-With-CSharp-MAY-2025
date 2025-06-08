//Input
int pokePower = int.Parse(Console.ReadLine()); //N
int distance = int.Parse(Console.ReadLine()); //M
int exhaustionFactor = int.Parse(Console.ReadLine()); //Y

//Calculations
int counter = 0;
double halfPercent = pokePower * 0.5d;
while (pokePower >= distance)
{
    pokePower -= distance;
    counter++;

    if (pokePower == halfPercent)
    {
        pokePower /= exhaustionFactor;
        continue;
    }
}

//Output
Console.WriteLine(pokePower);
Console.WriteLine(counter);