string input = string.Empty;
double money = 0;

//Inserting coins into the machine
while ((input = Console.ReadLine()) != "Start")
{
    double coinInput = double.Parse(input);

    switch (coinInput) //Checking the coin's validity
    {
        case 0.1:
        case 0.2:
        case 0.5:
        case 1:
        case 2:
            money += coinInput; break;
        default:
            Console.WriteLine($"Cannot accept {coinInput}");
            break;
    }
}

//Selecting products
double productPrice = 0;

while ((input = Console.ReadLine()) != "End")
{
    string product = input;

    switch (product)
    {
        case "Nuts":
            productPrice = 2.0;
            break;
        case "Water":
            productPrice = 0.7;
            break;
        case "Crisps":
            productPrice = 1.5;
            break;
        case "Soda":
            productPrice = 0.8;
            break;
        case "Coke":
            productPrice = 1.0;
            break;
        default:
            Console.WriteLine("Invalid product");
            continue;
    }

    if (money >= productPrice)
    {
        Console.WriteLine($"Purchased {product.ToLower()}");
        money -= productPrice;
    }
    else
        Console.WriteLine("Sorry, not enough money");
}

Console.WriteLine($"Change: {money:f2}");