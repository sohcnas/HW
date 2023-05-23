// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = Prompt("Введите размер массива: ");
int minValue = Prompt("Введите минимальное значение элементов массива: ");
int maxValue = Prompt("Введите максимальне значение элементов массива: ");
GetProduct(GetArray(size, minValue, maxValue));

void GetProduct(int[] array)
{
    int size = array.Length;
    int[] result = new int[size / 2 + 1];
    for (int i = 0; i < size / 2; i++)
    {
        result[i] = array[i] * array[size - i -1];
    }
    if (size%2 != 0) result[size / 2] = array[size / 2];
    Console.WriteLine(String.Join(" ", result));
}

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

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}