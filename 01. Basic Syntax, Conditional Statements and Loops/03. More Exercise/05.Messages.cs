int digits = int.Parse(Console.ReadLine());
int chars = 0;

string currentChar = string.Empty;
string sms = string.Empty;

while (chars < digits)
{
    string input = Console.ReadLine();
    chars++;

    if (input == "0")
        currentChar = " ";
    else if (input == "2")
        currentChar = "a";
    else if (input == "22")
        currentChar = "b";
    else if (input == "222")
        currentChar = "c";
    else if (input == "3")
        currentChar = "d";
    else if (input == "33")
        currentChar = "e";
    else if (input == "333")
        currentChar = "f";
    else if (input == "4")
        currentChar = "g";
    else if (input == "44")
        currentChar = "h";
    else if (input == "444")
        currentChar = "i";
    else if (input == "5")
        currentChar = "j";
    else if (input == "55")
        currentChar = "k";
    else if (input == "555")
        currentChar = "l";
    else if (input == "6")
        currentChar = "m";
    else if (input == "66")
        currentChar = "n";
    else if (input == "666")
        currentChar = "o";
    else if (input == "7")
        currentChar = "p";
    else if (input == "77")
        currentChar = "q";
    else if (input == "777")
        currentChar = "r";
    else if (input == "7777")
        currentChar = "s";
    else if (input == "8")
        currentChar = "t";
    else if (input == "88")
        currentChar = "u";
    else if (input == "888")
        currentChar = "v";
    else if (input == "9")
        currentChar = "w";
    else if (input == "99")
        currentChar = "x";
    else if (input == "999")
        currentChar = "y";
    else if (input == "9999")
        currentChar = "z";

    sms += currentChar;
}

Console.WriteLine(sms);