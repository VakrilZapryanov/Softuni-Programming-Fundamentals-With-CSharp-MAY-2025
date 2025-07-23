namespace _09.GreaterOfTwoValues;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "string":
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string greaterStringValue = GetMax(firstString, secondString);

                Console.WriteLine(greaterStringValue);
                break;
            case "char":
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                char greaterCharValue = GetMax(firstChar, secondChar);

                Console.WriteLine(greaterCharValue);
                break;
            case "int":
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int greaterIntValue = GetMax(firstNumber, secondNumber);

                Console.WriteLine(greaterIntValue);
                break;
        }
    }

    static string GetMax(string firstString, string secondString)
    {
        int greaterValue = firstString.CompareTo(secondString);

        if (greaterValue == 1)
            return firstString;

        return secondString;
    }

    static char GetMax(char firstChar, char secondChar)
    {
        if (firstChar > secondChar)
            return firstChar;

        return secondChar;
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
            return firstNumber;

        return secondNumber;
    }
}

