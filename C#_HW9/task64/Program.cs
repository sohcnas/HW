// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

int n = Prompt("Введите число n: ");
int m = Prompt("Введите число m: ");
PrintNumber(m, n);

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void PrintNumber(int m, int n)
{
    if (m > n)
    {
        Console.Write($" {n}");
        PrintNumber(m, n + 1);

    }
    else if (m < n)
    {
        Console.Write($" {m}");
        PrintNumber(m + 1, n);
    }
    else
    {
        Console.Write($" {m}");
        Console.WriteLine();
    }
}