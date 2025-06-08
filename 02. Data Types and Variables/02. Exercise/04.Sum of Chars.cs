int charsCount = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= charsCount; i++)
{
    char currentChar = char.Parse(Console.ReadLine());
    sum += currentChar;
}

Console.WriteLine($"The sum equals: {sum}");