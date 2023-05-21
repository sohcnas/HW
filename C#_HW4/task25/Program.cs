// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int number = Prompt ("Введите число: ");
int degree = Math.Abs(Prompt ("Введите степень числа: "));
DegreeNumber(number, degree);


int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void DegreeNumber (int number, int degree)
{
    int result = 1;
    for(int i = 0; i < degree; i++)
    {
        result = result * number;
    }
    Console.WriteLine($"{degree} степень числа {number} = {result}");
}