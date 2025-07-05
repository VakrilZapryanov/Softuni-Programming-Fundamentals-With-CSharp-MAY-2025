int wagons = int.Parse(Console.ReadLine());

int[] peopleInEachWagon = new int[wagons];

int totalPassengers = default;
for (int i = 0; i < peopleInEachWagon.Length; i++)
{
    peopleInEachWagon[i] = int.Parse(Console.ReadLine());
    totalPassengers += peopleInEachWagon[i];
}

Console.WriteLine(string.Join(" ", peopleInEachWagon));
Console.WriteLine(totalPassengers);