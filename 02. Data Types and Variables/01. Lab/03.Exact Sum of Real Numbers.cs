int numbers = int.Parse(Console.ReadLine());

decimal sum = 0;
for (int i = 1; i <= numbers; i++)
{
    sum += decimal.Parse(Console.ReadLine());
}

Console.WriteLine(sum);