namespace _06.MiddleCharacters;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(GetMiddleChars(input));
    }

    static string GetMiddleChars(string text)
    {
        int middleIndex = text.Length / 2;
        string middleChar = text[middleIndex].ToString();

        if (text.Length % 2 == 0)
        {
            middleChar = text[middleIndex - 1] + middleChar;
        }

        return middleChar;
    }
}

