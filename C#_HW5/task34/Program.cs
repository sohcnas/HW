// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// задачу решил для общего случа, числа могут быть любыми. Елси делать строго по условию, то необходимо было добавить проверку 
// на соответствие введеных чисел.

int[] array ;
int length = Prompt("Введите размер массива: ");
int minValue = Prompt("Введите min значение элемента массива: ");
int maxValue = Prompt("Введите max значение элемента массива: ");
CountEven(ArrayInput(length, minValue, maxValue));

int[] ArrayInput(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int Prompt (string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void CountEven (int[] array)
{
    int count = 0;
    Console.Write("[ ");
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
        Console.Write(item + " ");
    }
    Console.Write("] -> " + count);
    Console.WriteLine();
}
