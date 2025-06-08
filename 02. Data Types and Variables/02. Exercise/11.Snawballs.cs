using System.Numerics;
//Input
int snowballs = int.Parse(Console.ReadLine());

//Calculations
int highestSnowballSnow = 0;
int highestSnowballTime = 0;
int highestSnowballQuality = 0;
BigInteger highestSnowballValue = 0;

for (int currentBall = 1; currentBall <= snowballs; currentBall++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    int value = snowballSnow / snowballTime;
    BigInteger snowballValue = BigInteger.Pow(value, snowballQuality);

    if (snowballValue > highestSnowballValue)
    {
        highestSnowballSnow = snowballSnow;
        highestSnowballTime = snowballTime;
        highestSnowballQuality = snowballQuality;
        highestSnowballValue = snowballValue;
    }
}

//Output
Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");