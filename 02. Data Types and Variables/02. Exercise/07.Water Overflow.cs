int n = int.Parse(Console.ReadLine());

int capacity = 255;
int inputedWater = 0;
int counter = 0;

while (counter < n)
{
    int litersOfWater = int.Parse(Console.ReadLine());

    if (litersOfWater > (capacity - inputedWater))
    {
        Console.WriteLine("Insufficient capacity!");
        counter++;
        continue;
    }

    inputedWater += litersOfWater;
    counter++;
}

Console.WriteLine(inputedWater);
