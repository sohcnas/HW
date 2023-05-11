// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Main ();

void Main()
{
    int Number = Prompt("Введите пятизначное число");
    Palindrome(Valid(Number),Number);
}

int Prompt (string value)
{
    Console.WriteLine(value);
    int result = int.Parse(Console.ReadLine());
    return result;
}
bool Valid ( int value)
{
    if (value < 100000 && value > 9999)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Введено не корректное число");
        return false;
    }
}
void Palindrome (bool flag, int Number)
{
    if(flag)
    {
        int five = Number / 10000;
        int four = (Number / 1000)%10;
        int two = (Number / 10)%10;
        int one = Number % 10;
                Console.WriteLine("5=" + five + ", 4=" + four + ", 2=" + two + ", 1=" + one);
        if (five == one && four == two)
        {
            Console.WriteLine("Значение является полиндромом");
        }
        else
        {
            Console.WriteLine("Значение не является полиндромом");
        }
    }
}
