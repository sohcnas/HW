// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
FindMinSumStingArray(array);

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int value = int.Parse(Console.ReadLine());
//     return value;
// }

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void FindMinSumStingArray(int[,] array)
{
    int minSum = 0, temp = 0, minIndexString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) minSum += array[i, j];
            else temp += array[i, j];
        }
        if (i >= 1)
        {
            if (temp < minSum)
            {
                minSum = temp;
                minIndexString = i;
                temp = 0;
            }
        }
    }
    Console.WriteLine($"номер строки с наименьшей суммой равен: {minIndexString + 1}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

