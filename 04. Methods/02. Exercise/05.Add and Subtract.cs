namespace _05.AddAndSubtract;
class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int firstResult = AddFirstToSecond(firstNumber, secondNumber);
        Console.WriteLine(GetFinalResult(firstResult, thirdNumber));
    }

    static int AddFirstToSecond(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static int GetFinalResult(int firstResult, int thirdNumber)
    {
        return firstResult - thirdNumber;
    }
}

