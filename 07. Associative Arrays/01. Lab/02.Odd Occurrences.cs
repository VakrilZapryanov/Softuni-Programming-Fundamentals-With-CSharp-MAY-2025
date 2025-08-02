namespace _02.OddOccurrences;
class Program
{
    static void Main(string[] args)
    {
        //Input
        string[] words = Console.ReadLine()
            .Split()
            .Select(word => word.ToLower())
            .ToArray();

        //Action
        Dictionary<string, int> wordsCount = new();

        foreach (string word in words)
        {
            if (wordsCount.ContainsKey(word) == false)
                wordsCount.Add(word, 0);

            wordsCount[word]++;
        }

        string[] oddCountWords = wordsCount
            .Where(word => word.Value % 2 != 0)
            .Select(word => word.Key)
            .ToArray();

        //Output
        Console.WriteLine(string.Join(" ", oddCountWords));
    }
}

