//Input
int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

//Calculations
int headsetCount = lostGamesCount / 2;
int mouseCount = lostGamesCount / 3;
int keyboardCount = lostGamesCount / 6;
int displayCount = keyboardCount / 2;

double bill = headsetPrice * headsetCount +
              mousePrice * mouseCount +
              keyboardPrice * keyboardCount +
              displayPrice * displayCount;

//Output
Console.WriteLine($"Rage expenses: {bill:f2} lv.");