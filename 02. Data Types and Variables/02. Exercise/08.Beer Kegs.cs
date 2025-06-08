byte kegsCount = byte.Parse(Console.ReadLine());

byte counter = 1;
string biggestKegModel = string.Empty;
double biggestKegVolume = 0;
while (counter <= kegsCount)
{
    string currentKegModel = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double currentKegVolume = Math.PI * (radius * radius) * height;

    if (currentKegVolume > biggestKegVolume)
    {
        biggestKegVolume = currentKegVolume;
        biggestKegModel = currentKegModel;
    }
    counter++;
}

Console.WriteLine(biggestKegModel);