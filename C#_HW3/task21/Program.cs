// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Main();

void Main ()
{
    int x1 = Promt("Введите координату Х1: ");
    int y1 = Promt("Введите координату Y1: ");
    int z1 = Promt("Введите координату Z1: ");
    int x2 = Promt("Введите координату Х2: ");
    int y2 = Promt("Введите координату Y2: ");
    int z2 = Promt("Введите координату Z2: ");
    Distance(x1, y1, z1, x2, y2, z2);
}

int Promt (string Value)
{
    Console.Write(Value);
    int coordinate = int.Parse(Console.ReadLine());
    return coordinate;
}

void Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double DistanceValue = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine("Дистанция равна: " + DistanceValue);
}