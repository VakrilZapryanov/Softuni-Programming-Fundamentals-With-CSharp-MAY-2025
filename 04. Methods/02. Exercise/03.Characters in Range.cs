namespace _03.CharactersInRange;
class Program
{
    static void Main(string[] args)
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());

        PrintCharacters(firstChar, secondChar);
    }

    static void PrintCharacters(char firstCharInput, char secondCharInput)
    {
        char firstChar = firstCharInput, secondChar = secondCharInput;

        if (secondChar < firstChar)
        {
            firstChar = secondCharInput;
            secondChar = firstCharInput;
        }

        for (int i = firstChar + 1; i < secondChar; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}
