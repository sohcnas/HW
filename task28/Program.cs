// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Main ();

void Main ()
{
    int limit = Prompt(); // введеное пользователем значение
    int result = 1;  // накапливаемая сумма значения
    for(int i = 1; i <= limit; i++)
    {
        result = result * i;
    }
    if (limit == 0 ) result = 0;
    Console.WriteLine($"Результат равен: {result}");
}

int Prompt ()
{
    Console.WriteLine("Введите число: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}