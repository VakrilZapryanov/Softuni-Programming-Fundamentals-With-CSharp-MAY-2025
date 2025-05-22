//Input
string username = Console.ReadLine();

//Calculations
string password = string.Empty;

for (int i = username.Length - 1; i >= 0; i--)
{
    char currentChar = username[i];
    password += currentChar;
}

int incorrectPasswordsCount = 0;
while (true)
{
    string passwordInput = Console.ReadLine(); //Input

    if (passwordInput == password)
    {
        Console.WriteLine($"User {username} logged in."); //Output
        break;
    }
    else if (incorrectPasswordsCount > 4)
    {
        Console.WriteLine($"User {username} blocked!"); //Output
        break;
    }
    else if (passwordInput != password)
    {
        Console.WriteLine("Incorrect password. Try again."); //Output
        incorrectPasswordsCount++;
    }

    incorrectPasswordsCount++;
}