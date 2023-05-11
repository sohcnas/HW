// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Main ();

void Main ()
{
    int Number = Prompt ("Введите число: ");
    CalculationCube(Number);
}

int Prompt (string Value)
{
    Console.Write(Value);
    int Number = int.Parse(Console.ReadLine());
    return Number;
}

void CalculationCube (int Number)
{
    for (int i = 1 ; i <= Number; i++)
    {
        Console.WriteLine("Куб " + i + " = " + Math.Pow(i, 3));
    }
}