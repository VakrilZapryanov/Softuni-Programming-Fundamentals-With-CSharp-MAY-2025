using System.Diagnostics.Metrics;

namespace _05.Orders;
class Program
{
    static void Main(string[] args)
    {
        //Input
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        double bill = 0;

        PrintTotalPrice(product, quantity);
    }

    static void PrintTotalPrice(string product, int quantity)
    {
        //Prices
        double coffeePrice = 1.50;
        double waterPrice = 1.00;
        double cokePrice = 1.40;
        double snacksPrice = 2.00;

        //Calculations
        double bill = default;

        switch (product)
        {
            case "coffee":
                bill = quantity * coffeePrice;
                break;
            case "water":
                bill = quantity * waterPrice;
                break;
            case "coke":
                bill = quantity * cokePrice;
                break;
            case "snacks":
                bill = quantity * snacksPrice;
                break;
        }

        //Output
        Console.WriteLine($"{bill:f2}");
    }
}
