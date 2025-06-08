int number = int.Parse(Console.ReadLine());

for (int currentNum = 1; currentNum <= number; currentNum++)
{
    int sum = 0;
    int digits = currentNum;
    while (digits > 0)
    {
        sum += digits % 10;
        digits /= 10;
    }
    bool isSpecial = sum == 5 || sum == 7 || sum == 11;

    if (isSpecial)
    {
        Console.WriteLine($"{currentNum} -> True");
    }
    else
    {
        Console.WriteLine($"{currentNum} -> False");
    }
}