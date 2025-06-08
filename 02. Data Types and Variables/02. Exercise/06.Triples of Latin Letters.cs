int input = int.Parse(Console.ReadLine());

int starterChar = 97;
int endChar = starterChar + input;

for (int i = starterChar; i < endChar; i++)
{
    for (int k = starterChar; k < endChar; k++)
    {
        for (int j = starterChar; j < endChar; j++)
        {
            Console.WriteLine($"{(char)i}{(char)k}{(char)j}");
        }
    }
}