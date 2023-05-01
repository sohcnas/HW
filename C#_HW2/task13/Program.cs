// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Main();

void Main()
{
    Console.WriteLine("Введите число ");
    int Number = int.Parse(Console.ReadLine());
    if (Number > 99)
    {
        if (Number > 99 && Number < 1000)
        {
            Digit (Number);
        }
        else if (Number > 999 && Number < 10000)
        {
            Number = Number / 10;
            Digit (Number);
        }
        else if (Number > 9999 && Number < 100000)
        {
            Number = Number / 100;
            Digit (Number);
        }
        else if (Number > 99999 && Number < 1000000)
        {
            Number = Number / 1000;
            Digit (Number);
        }
        else Console.WriteLine("Слишком большое число");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

void Digit (int Number)
{
    Number = Number % 10;
    Console.WriteLine("Третья цифра числа равна " + Number);
}