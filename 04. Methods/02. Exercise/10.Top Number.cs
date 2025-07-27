namespace _10.TopNumber;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (HasOddDigit(i) && isDivisibleByEight(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool HasOddDigit(int number)
    {
        while (number > 0)
        {
            int digit = number % 10;

            if (digit % 2 != 0)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }

    static bool isDivisibleByEight(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum % 8 == 0;
    }
}

