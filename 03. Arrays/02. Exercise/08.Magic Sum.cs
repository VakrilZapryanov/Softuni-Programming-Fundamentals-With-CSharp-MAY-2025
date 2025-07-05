//Input
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int magicNumber = int.Parse(Console.ReadLine());

//Calculations
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == magicNumber)
        {
            //Output
            Console.WriteLine($"{numbers[i]} {numbers[j]}");
        }
    }
}