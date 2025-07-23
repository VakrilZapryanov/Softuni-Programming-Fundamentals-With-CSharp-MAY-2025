namespace _07.RepeatString;
class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int repeatsCount = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatString(word, repeatsCount));
    }

    static string RepeatString(string word, int repeatsCount)
    {
        string result = string.Empty;
        for (int i = 1; i <= repeatsCount; i++)
        {
            result += word;
        }
        return result;
    }
}

