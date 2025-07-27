namespace _01.SmallestOfThreeNumbers;
class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(FindingSmallestNumber(firstNumber, secondNumber, thirdNumber));
    }

    static int FindingSmallestNumber(int num1, int num2, int num3)
    { 
        int result = Math.Min(num1, num2);
        return Math.Min(result, num3);
    }
}
