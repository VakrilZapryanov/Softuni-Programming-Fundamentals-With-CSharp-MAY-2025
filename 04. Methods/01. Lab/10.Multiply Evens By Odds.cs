using System.Runtime.Intrinsics.X86;

namespace _10.MultiplyEvensByOdds;
class Program
{
    static void Main(string[] args)
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine(GetMultipleOfEvenAndOdds(number));
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = default;

        while (number > 0)
        {
            int digit = number % 10;

            if (number % 2 == 0)
                sum += digit;

            number /= 10;
        }
        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = default;

        while (number > 0)
        {
            int digit = number % 10;

            if (number % 2 != 0)
                sum += digit;

            number /= 10;
        }
        return sum;
    }
}