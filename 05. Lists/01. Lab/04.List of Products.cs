namespace _04.ListOfProducts;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<string> products = new(n);

        while (n > 0)
        {
            string product = Console.ReadLine();
            products.Add(product);

            n--;
        }

        products.Sort();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{products[i]}");
        }
    }
}
