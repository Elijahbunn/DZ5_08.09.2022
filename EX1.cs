Console.WriteLine("Введите переменную k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную d1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную d2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
}
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами {x} и {y}");
}
