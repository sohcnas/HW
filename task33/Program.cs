// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = new[] {6, 7, 19, 345, 3};
FindValue(Prompt("Введите искомое число: "), array);

int Prompt (string message)
{
    int value;
    Console.WriteLine(message);
    value = int.Parse(Console.ReadLine());
    return value;
}

void FindValue (int value, int[] array)
{
    bool flag = false;
    Console.Write("[");
    foreach (var item in array)
    {
        if (item == value)
        {
            flag = true;
        }
        Console.Write($" {item} ");
    }
    if (flag)
    {
        Console.Write($"] - > ДА");
    }
    else
    {
        Console.Write($"] - > НЕТ");   
    }
    Console.WriteLine();
}