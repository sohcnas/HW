// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int leftEdg = 10;
int rightEdg = 99;
int size = Prompt("Введите размер массива: ");
int minValue = Prompt("Введите минимальное значение элементов массива: ");
int maxValue = Prompt("Введите максимальне значение элементов массива: ");
FindNumber(leftEdg, rightEdg, GetArray(size, minValue, maxValue));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}
void FindNumber(int leftEdg, int rightEdg, int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > leftEdg && item < rightEdg) count++;
    }
    Console.WriteLine($"Количество элементов массива попадающих в диапазон равно: {count}");
}
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}