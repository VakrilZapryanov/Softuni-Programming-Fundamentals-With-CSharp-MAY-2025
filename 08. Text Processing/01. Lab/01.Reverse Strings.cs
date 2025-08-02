namespace _01.ReverseStrings;
class Program
{
    static void Main(string[] args)
    {
        string wordInput = string.Empty;
        while ((wordInput = Console.ReadLine()) != "end")
        {
            string reversedWord = string.Empty;
            for (int i = wordInput.Length - 1; i >= 0; i--)
            {
                reversedWord += wordInput[i];
            }

            Console.WriteLine(string.Concat(wordInput, " = ", reversedWord));
        }
    }
}
