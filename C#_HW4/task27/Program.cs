// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int number = Prompt ("Введите число: ");
SumNumber(number);

int Prompt (string message)
{
    Console.WriteLine (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SumNumber (int number)
{
    int sum = 0;
    int i;
    for(i = number; i > 9 ; i = i / 10)
    {
        sum = sum + i % 10;
    }
    sum = sum + i;
    Console.WriteLine(sum);
}