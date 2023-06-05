// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

int m = Prompt("Введите индекс массива m: (1-3): ");
int n = Prompt("Введите индекс массива n: (1-4): ");
int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
CheckArray (array, m, n);

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

void CheckArray (int[,] array, int m, int n)
{
    if (array.GetLength(0) >= m && m>0)
    {
        if(array.GetLength(1)>=n && n>0)
        {
            Console.WriteLine($"[{m}, {n}] -> {array[m-1,n-1]}");
        }
        else Console.WriteLine($"[{m}, {n}] -> такого числа в массиве нет");
    }
    else Console.WriteLine($"[{m}, {n}] -> такого числа в массиве нет");
}