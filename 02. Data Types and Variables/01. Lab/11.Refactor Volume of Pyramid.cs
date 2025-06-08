//Input
Console.Write("Length: ");
double length = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());

//Calculations
double volume = (length * width * height) / 3;
Console.WriteLine($"Pyramid Volume: {volume:f2}");
