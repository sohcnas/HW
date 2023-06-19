// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int n = Prompt("Введите число n: ");
int m = Prompt("Введите число m: ");
PrintSumNumber(m, n, 0);

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void PrintSumNumber(int m, int n, int sum)
{
    if (m > n)
    {
        PrintSumNumber(m, n + 1, sum+=n);

    }
    else if (m < n)
    {
        PrintSumNumber(m + 1, n, sum+=m);
    }
    else
    {
        sum+=m;
        Console.Write($"{sum}");
        Console.WriteLine();
    }
}