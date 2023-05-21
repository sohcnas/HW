// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Main ();

void Main ()
{
    int limit = Prompt(); // введеное пользователем значение
    int result = 0;  // накапливаемая сумма значения
    for(int i = 1; i <= limit; i++)
    {
        result = result + i;
    }
    Console.WriteLine($"Результат равен: {result}");
}

int Prompt ()
{
    Console.WriteLine("Введите число: ");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}