using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace _04.PasswordValidator;
class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();

        bool passwordLengthCheck = CheckLength(password);
        bool passwordSymbolCkeck = CheckForSpecialSymbols(password);
        bool passwordDigitsCheck = CheckForAtLeastTwoDigits(password);

        if (!passwordLengthCheck)
            Console.WriteLine("Password must be between 6 and 10 characters");

        if (!passwordSymbolCkeck)
            Console.WriteLine("Password must consist only of letters and digits");

        if (!passwordDigitsCheck)
            Console.WriteLine("Password must have at least 2 digits");


        if (passwordLengthCheck && passwordSymbolCkeck && passwordDigitsCheck)
            Console.WriteLine("Password is valid");
    }

    static bool CheckLength(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
            return true;

        return false;
    }

    static bool CheckForSpecialSymbols(string password)
    {
        for (int i = 0; i < password.Length; i++)
        {
            char currentChar = password[i];

            if (currentChar >= 48 && currentChar <= 57 || 
                currentChar >= 65 && currentChar <= 90 || 
                currentChar >= 97 && currentChar <= 122)  
            {
                continue;
            }
            return false;
        }

        return true;
    }

    static bool CheckForAtLeastTwoDigits(string password)
    {
        int counter = 0;
        for (int i = 0; i < password.Length; i++)
        {
            char currentChar = password[i];

            if (currentChar >= 48 && currentChar <= 57)
            {
                counter++;
            }
        }

        if (counter >= 2)
            return true;

        return false;
    }
}
