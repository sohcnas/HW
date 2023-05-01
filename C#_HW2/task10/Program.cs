// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Main ();

void Main ()
{
    Console.WriteLine("Введите трехзначное число: ");
    int Number = int.Parse(Console.ReadLine());
    if (Number > 99 && Number < 1000)
    {
        Number = Number / 10; // убираем разряд едениц
        Number = Number % 10; // получаем вторую цифру
        Console.WriteLine("Вторя цифра числа равна " + Number);
    }
    else
    {
        Console.WriteLine("Введеное число " + Number + " не трехзначное");
    }
}

