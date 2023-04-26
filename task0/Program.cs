// Напишите программу, которая на входи принимает число и выдает его квадрат

// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

Console.WriteLine("ВВедите число:");
int number = int.Parse(Console.ReadLine());
number = number * number;
Console.WriteLine(number);