using System.Text;

namespace _02.RepeatStrings;
class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();

        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            for (int i = 1; i <= word.Length; i++)
            {
                result.Append(word);
            }
        }

        Console.WriteLine(result);
    }
}

