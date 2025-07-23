namespace _04.PrintingTriangle;
class Program
{
    static void Main(string[] args)
    {
        int endNumber = int.Parse(Console.ReadLine());
        PrintFirstHalf(endNumber);
        PrintSecondHalf(endNumber);
    }

    static void PrintFirstHalf(int endNumber)
    {
        for (int i = 1; i <= endNumber; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSecondHalf(int endNumber)
    {
        for (int i = endNumber - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}