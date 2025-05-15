int number = int.Parse(Console.ReadLine());

while (true)
{
    if (number % 2 == 0) //even
    {
        Console.WriteLine($"The number is: {Math.Abs(number)}");
        break;
    }
    else
    {
        Console.WriteLine("Please write an even number.");
        number = int.Parse(Console.ReadLine());
    }
}