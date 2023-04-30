// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Main();

void Main()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Рандомное число равно " + rand);
    int a = FindFirstDigitNumber(rand);
    int b = FindSecondDigitNumber(rand);
    FindLargestNumber( a, b);

    int rand1 = new Random().Next(10, 100);
    Console.WriteLine("Рандомное число равно " + rand1);
    int a1 = FindFirstDigitNumber(rand1);
    int b1 = FindSecondDigitNumber(rand1);
    FindLargestNumber( a1, b1);
    }
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

int FindFirstDigitNumber(int r)
{
    int result = r / 10;
    return result;
}

int FindSecondDigitNumber(int r)
{
    int result = r % 10;
    return result;
}