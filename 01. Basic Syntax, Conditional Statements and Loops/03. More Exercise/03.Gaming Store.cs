double balance = double.Parse(Console.ReadLine());

string input = string.Empty;
double bill = 0;
while ((input = Console.ReadLine()) != "Game Time")
{
    string game = input;

    double currentGamePrice = default;
    switch (game)
    {
        case ("OutFall 4"): currentGamePrice = 39.99; break;
        case ("CS: OG"): currentGamePrice = 15.99; break;
        case ("Zplinter Zell"): currentGamePrice = 19.99; break;
        case ("Honored 2"): currentGamePrice = 59.99; break;
        case ("RoverWatch"): currentGamePrice = 29.99; break;
        case ("RoverWatch Origins Edition"): currentGamePrice = 39.99; break;
        default:
            Console.WriteLine("Not Found");
            continue;
    }

    if (currentGamePrice > balance)
    {
        Console.WriteLine("Too Expensive");
        continue;
    }

    if (balance >= currentGamePrice)
    {
        balance -= currentGamePrice;
        bill += currentGamePrice;
        Console.WriteLine("Bought " + game); continue;
    }

    if (balance <= 0)
    {
        Console.WriteLine("Out of money!"); break;
    }
}

if (balance > 0)
    Console.WriteLine($"Total spent: ${bill:f2}. Remaining: ${balance:f2}");
else
    Console.WriteLine("Out of money!");