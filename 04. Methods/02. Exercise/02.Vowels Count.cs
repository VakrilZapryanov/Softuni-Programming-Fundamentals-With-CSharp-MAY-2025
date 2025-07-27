namespace _02.VowelsCount;
class Program
{  
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Console.WriteLine(GetVowelsCount(input.ToLower()));
    }

    static int GetVowelsCount(string word)
    {
        int vowelsCount = default;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'a' ||
                word[i] == 'o' ||
                word[i] == 'e' ||
                word[i] == 'i' ||
                word[i] == 'u')
            {
                vowelsCount++;
            }
        }

        return vowelsCount;
    }
}
