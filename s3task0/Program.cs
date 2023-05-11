// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Main ();
void Main ()
{
    int x = Prompt ("Введите координату Х: ");
    int y = Prompt ("Введите координату Y: ");
    FindQuarterPlane( x, y);
}
int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void FindQuarterPlane ( int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I четверть ");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("II четверть ");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("III четверть ");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("IV четверть ");
    }
}