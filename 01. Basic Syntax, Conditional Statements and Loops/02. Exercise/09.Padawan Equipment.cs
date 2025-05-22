//Input
double amountOfMoney = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());

double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());


//Calculations
int neededLightsabers = studentsCount + (int)Math.Ceiling(studentsCount * 0.1);
int neededRobes = studentsCount;
int neededBelts = studentsCount;

int freeBelts = neededBelts / 6;

double bill = lightsaberPrice * neededLightsabers +
              robePrice * neededRobes +
              beltPrice * (neededBelts - freeBelts);

//Output
if (amountOfMoney >= bill)
    Console.WriteLine($"The money is enough - it would cost {bill:f2}lv.");
else
    Console.WriteLine($"John will need {bill - amountOfMoney:f2}lv more.");
