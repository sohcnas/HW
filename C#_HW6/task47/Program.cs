// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = Convert.ToInt32(Prompt("Введите индекс массива m: "));
int n = Convert.ToInt32(Prompt("Введите индекс массива n: "));
double minValue = Prompt("Введите минимальное значение элемента массива: ");
double maxValue = Prompt("Введите максимальное значение элемента массива: ");
double[,] array = GetArray(m, n, minValue, maxValue);
PrintArray(array);

double Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(minValue + (new Random().NextDouble() * (maxValue - minValue)), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}