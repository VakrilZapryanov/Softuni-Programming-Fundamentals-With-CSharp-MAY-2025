int nums = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= nums; i++)
{
    int oddNumber = i * 2 - 1;
    sum += oddNumber;
    Console.WriteLine(oddNumber);
}

Console.WriteLine("Sum: " + sum);