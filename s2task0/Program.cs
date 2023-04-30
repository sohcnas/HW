// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int rand = new Random().Next(10, 100);
Console.WriteLine("Рандомное число равно " + rand);
int a = rand / 10;
int b = rand % 10;
FindLargestNumber( a, b);


void FindLargestNumber( int a, int b)
{
    if (a > b) 
    {
        Console.WriteLine("Наибольшая цифра числа = " + a);
    }
    else if(a < b)
    {
        Console.WriteLine("Наибольшая цифра числа = " + b);
    }
    else 
    {
        Console.WriteLine("Числа равны");
    }
}