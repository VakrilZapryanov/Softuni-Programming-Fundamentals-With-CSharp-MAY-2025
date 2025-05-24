float firstNum = float.Parse(Console.ReadLine());
float secondNum = float.Parse(Console.ReadLine());
float thirdNum = float.Parse(Console.ReadLine());

float maxNum = 0;
float middleNum = 0;
float minNum = 0;

if (firstNum >= secondNum && firstNum >= thirdNum)
{
    maxNum = firstNum;

    if (secondNum >= thirdNum)
    {
        middleNum = secondNum;
        minNum = thirdNum;
    }
    else if (thirdNum >= secondNum)
    {
        middleNum = thirdNum;
        minNum = secondNum;
    }
}
else if (secondNum >= firstNum && secondNum >= thirdNum)
{
    maxNum = secondNum;

    if (firstNum >= thirdNum)
    {
        middleNum = firstNum;
        minNum = thirdNum;
    }
    else if (thirdNum >= firstNum)
    {
        middleNum = thirdNum;
        minNum = firstNum;
    }
}
else
{
    maxNum = thirdNum;

    if (firstNum >= secondNum)
    {
        middleNum = firstNum;
        minNum = secondNum;
    }
    else if (secondNum >= firstNum)
    {
        middleNum = secondNum;
        minNum = firstNum;
    }
}

Console.WriteLine(maxNum);
Console.WriteLine(middleNum);
Console.WriteLine(minNum);