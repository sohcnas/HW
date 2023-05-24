// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементом массива.
// [3 7 22 2 78] -> 76

int size = Convert.ToInt32(Prompt("Введите размер массива: "));
double minValue = Prompt("Введите минимальное значение элементов массива: ");
double maxValue = Prompt("Введите максимальне значение элементов массива: ");
GetMaxMinDifference(GetArray(size, minValue, maxValue));

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = minValue + (new Random().NextDouble() * (maxValue - minValue));
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}

double Prompt(string message)
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}

void GetMaxMinDifference(double[] array)
{
    double min = 0, max = 0;
    min = max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        else if (max < array[i]) max = array[i];
    }
    Console.WriteLine($"Разница между минимальным и максимальным элементом массива равна: {max - min}");
}
