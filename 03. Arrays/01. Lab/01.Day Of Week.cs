string[] daysOfWeek =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

short day = short.Parse(Console.ReadLine());
if (day > 0 && day < 8)
{
    Console.WriteLine(daysOfWeek[day - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}