// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Main ();

void Main ()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Рандомное число равно " + rand);
    int Number = rand % 10;
    Number = Number + rand / 100 * 10;
    Console.WriteLine(Number);
}