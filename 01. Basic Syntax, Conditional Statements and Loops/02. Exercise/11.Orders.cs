int ordersCount = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int currentOrder = 1; currentOrder <= ordersCount; currentOrder++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double price = days * capsulesCount * capsulePrice;
    totalPrice += price;

    Console.WriteLine($"The price for the coffee is: ${price:f2}");
}

Console.WriteLine($"Total: ${totalPrice:f2}");
