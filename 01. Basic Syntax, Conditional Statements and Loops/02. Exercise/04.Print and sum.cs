//Input
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;

for (int currentNum = start; currentNum <= end; currentNum++)
{
    Console.Write(currentNum + " "); //Output
    sum += currentNum;
}

Console.WriteLine(); //Next row

//Output
Console.WriteLine("Sum: " + sum);
