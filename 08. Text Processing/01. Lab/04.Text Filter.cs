namespace _04.TextFilter;
class Program
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine()
            .Split(", ");

        string text = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            string replacedWithAsterisks = new('*', word.Length);

            text = text.Replace(word, replacedWithAsterisks);
        }

        Console.WriteLine(text);
    }
}

