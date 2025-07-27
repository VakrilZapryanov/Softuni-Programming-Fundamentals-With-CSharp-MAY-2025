namespace _02.Gauss_Trick;
class Program
{
    static void Main(string[] args)
    {
        //Input
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        //Calculation
        int originalCount = numbers.Count;
        for (int i = 0; i < originalCount / 2; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }

        //Outputa
        Console.WriteLine(string.Join(" ", numbers));
    }
}

