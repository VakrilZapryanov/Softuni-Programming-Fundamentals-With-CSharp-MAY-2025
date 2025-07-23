namespace _06.CalculateRectangleArea;
class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine(GetArea(width, height));
    }

    static int GetArea(int width, int height)
    {
        return width * height;
    }
}

