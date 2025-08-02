using System.Text;

namespace _05.Digits_LettersAndOther;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        StringBuilder digits = new();
        StringBuilder letters = new();
        StringBuilder other = new();

        foreach (var character in input)
        {
            if (char.IsDigit(character))
                digits.Append(character);
            else if (char.IsLetter(character))
                letters.Append(character);
            else
                other.Append(character);
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }
}

