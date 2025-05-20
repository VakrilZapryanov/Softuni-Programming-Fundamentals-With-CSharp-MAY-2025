//Input
int peopleCount = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();

//Calculations
double priceForOne = 0;
double totalPrice = 0;

if (groupType == "Students")
{
    switch (day)
    {
        case ("Friday"): priceForOne = 8.45; break;
        case ("Saturday"): priceForOne = 9.8; break;
        case ("Sunday"): priceForOne = 10.46; break;
    }

    totalPrice = priceForOne * peopleCount;

    //For Students – if the group is 30 or more people, you should reduce the total price by 15%.
    if (peopleCount >= 30)
    {
        totalPrice -= totalPrice * 0.15;
    }
}
else if (groupType == "Business")
{
    switch (day)
    {
        case ("Friday"): priceForOne = 10.9; break;
        case ("Saturday"): priceForOne = 15.6; break;
        case ("Sunday"): priceForOne = 16; break;
    }

    totalPrice = priceForOne * peopleCount;

    //For Business – if the group is 100 or more people, 10 of the people stay for free.
    if (peopleCount >= 100)
    {
        totalPrice -= priceForOne * 10;
    }
}
else if (groupType == "Regular")
{

    switch (day)
    {
        case ("Friday"): priceForOne = 15; break;
        case ("Saturday"): priceForOne = 20; break;
        case ("Sunday"): priceForOne = 22.5; break;
    }

    totalPrice = priceForOne * peopleCount;

    //For Regular – if the group is between 10 and 20 people (both inclusively), reduce the total price by 5%.
    if (peopleCount >= 10 && peopleCount <= 20)
    {
        totalPrice -= totalPrice * 0.05;
    }
}

//Output
Console.WriteLine($"Total price: {totalPrice:f2}");