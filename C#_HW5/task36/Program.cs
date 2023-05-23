// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

int size = Prompt("Введите размер массива: ");
int minValue = Prompt("Введите минимальное значение элементов массива: ");
int maxValue = Prompt("Введите максимальне значение элементов массива: ");
FindSumEvenIndexNumber(GetArray(size, minValue, maxValue));

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
    int value = int.Parse(Console.ReadLine());
    return value;
}

void FindSumEvenIndexNumber(int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum+=array[i];
    }
    Console.WriteLine($"Сумма элементов массива с нечетными индексами равна: {sum}");
}