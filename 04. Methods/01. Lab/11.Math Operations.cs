namespace _11.MathOperations;
class Program
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(CalculatingResult(firstNumber, symbol, secondNumber));
    }

    static double CalculatingResult(double firstNumber, char symbol, double secondNumber)
    {
        double result = default;

        switch (symbol)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
        }

        return result;
    }
}

