// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Main ();

void Main ()
{
    NumberCount(Prompt());
}

int Prompt ()
{
    Console.WriteLine("Введите произвольное целое число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void NumberCount (int number)
{
    int count = 0;
    for(int i = 1; i < number; i = i * 10)
    {
        count++;
    }
    Console.WriteLine($"В числе {number} цифр {count}");
}