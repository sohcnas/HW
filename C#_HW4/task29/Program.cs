// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]

// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]
int[] array = new int[8];
array = Prompt (array);
PrintArray(array);

int[] Prompt (int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите элемент массива {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
void PrintArray (int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
}