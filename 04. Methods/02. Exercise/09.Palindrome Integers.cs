namespace _09.PalindromeIntegers;
class Program
{
    static void Main(string[] args)
    {
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(input));
        }

        static bool IsPalindrome(string text)
        {
            string reversedString = ReversingString(text);
            return text == reversedString;
        }

        static string ReversingString(string stringForReversing)
        {
            char[] reversedText = stringForReversing.ToCharArray();
            Array.Reverse(reversedText);
            return new string(reversedText);
        }
    }
}
