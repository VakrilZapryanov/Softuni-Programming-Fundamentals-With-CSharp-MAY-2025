namespace _03.MergingLists;
class Program
{
    static void Main(string[] args)
    {
        //Input
        List<int> list1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> list2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        //Action
        List<int> result = new();

        int maxCount = list1.Count > list2.Count
            ? list1.Count
            : list2.Count;
        for (int i = 0; i < maxCount; i++)
        {
            if (list1.Count > i)
                result.Add(list1[i]);

            if (list2.Count > i)
                result.Add(list2[i]);
        }

        //Output
        Console.WriteLine(string.Join(" ", result));
    }
}

