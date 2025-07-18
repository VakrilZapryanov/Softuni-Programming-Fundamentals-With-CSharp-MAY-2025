//Input
int fieldSize = int.Parse(Console.ReadLine());
int[] bugPlases = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

//Action
int[] field = new int[fieldSize];
for (int i = 0; i < bugPlases.Length; i++)
{
    int bugIndex = bugPlases[i];
    if (bugIndex >= 0 && bugIndex < field.Length)
    {
        field[bugIndex] = 1;
    }
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    string[] movementDescription = command
        .Split()
        .ToArray();

    int bugIndex = int.Parse(movementDescription[0]);
    string direction = movementDescription[1];
    int flyLength = int.Parse(movementDescription[2]);

    if (bugIndex >= 0 && bugIndex <= field.Length - 1 && field[bugIndex] == 1)
    {
        field[bugIndex] = 0;
        
        int landIndex = 0;
        switch (direction)
        {
            case "left": // -
                landIndex = bugIndex - flyLength;
                while (landIndex >= 0 && landIndex <= field.Length - 1 && field[landIndex] == 1)
                {
                    landIndex -= flyLength;
                }

                if (landIndex >= 0 && landIndex <= field.Length - 1)
                {
                    field[landIndex] = 1;
                }
                break;

            case "right": // +
                landIndex = bugIndex + flyLength;
                while (landIndex >= 0 && landIndex <= field.Length - 1 && field[landIndex] == 1)
                {
                    landIndex += flyLength;
                }

                if (landIndex >= 0 && landIndex <= field.Length - 1)
                {
                    field[landIndex] = 1;
                }
                break;
        }
    }
}

//Output
Console.WriteLine(string.Join(" ", field));
