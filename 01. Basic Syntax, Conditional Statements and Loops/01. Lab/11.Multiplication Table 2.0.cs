int firstNum = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{firstNum} X {times} = {firstNum * times}");
    times++;
}
while (times <= 10);