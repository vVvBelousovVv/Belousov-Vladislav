// Белоусов Владислав группа 22-ИСП-2/2 Вариант 24
try
{
    Console.Write("Введите x:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    double x = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.ForegroundColor = ConsoleColor.DarkGray;
    double res = (x - Math.Sin(10 * x) + Math.Abs(x * x * x * x) - (x * x * x * x * x)) ; 
        Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
