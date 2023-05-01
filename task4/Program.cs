// Напишите программу, которая на вход принимает трехзначное число и выводит последнюю его цифру

Console.WriteLine("Введите трехзначное число");
int Number = int.Parse(Console.ReadLine());
if ( Number > 99 && Number < 1000)
{
    Console.WriteLine("Последняя цифра числа: " + Number%10);
}