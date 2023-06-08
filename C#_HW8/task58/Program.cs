// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] array1 = GetArray(5, 4, 0, 9);
PrintArray(array1);

int[,] array2 = GetArray(4, 2, 0, 9);
PrintArray(array2);

PrintArray(MultiplicationArray(array1, array2));

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

int[,] MultiplicationArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int z = 0; z < array2.GetLength(1); z++)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                resultArray[i, z] += array1[i, j] * array2[j, z];
            }
        }
    }
    return resultArray;
}

// void FindMinSumStingArray(int[,] array)
// {
//     int minSum = 0, temp = 0, minIndexString = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0) minSum += array[i, j];
//             else temp += array[i, j];
//         }
//         if (i >= 1)
//         {
//             if (temp < minSum)
//             {
//                 minSum = temp;
//                 minIndexString = i;
//                 temp = 0;
//             }
//         }
//     }
//     Console.WriteLine($"номер строки с наименьшей суммой равен: {minIndexString + 1}");
// }

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

