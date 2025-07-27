using System.Numerics;
namespace _08.FactorialDivision;
class Program
{
    static void Main(string[] args)
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine($"{(double)CalculateFactorial(firstNumber) / (double)CalculateFactorial(secondNumber):f2}");

    }

    static double CalculateFactorial(BigInteger number)
    {
        double result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}

