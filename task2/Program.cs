// Напишите программу, которая будет вывдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("ВВедите номер дня недели:");
int NumDay = int.Parse(Console.ReadLine()); // сохраним введеное пользователем число в переменную 
if (NumDay == 1) Console.WriteLine("Сегодня понедельник");
if (NumDay == 2) Console.WriteLine("Сегодня вторник");
if (NumDay == 3) Console.WriteLine("Сегодня среда");
if (NumDay == 4) Console.WriteLine("Сегодня четверг");
if (NumDay == 5) Console.WriteLine("Сегодня пятница");
if (NumDay == 6) Console.WriteLine("Сегодня суббота");
if (NumDay == 7) Console.WriteLine("Сегодня воскресенье");
