// Написать программу, которая вводит два числа и проверяет являетс ли первое квадратом второго

// 25 -> 5 да 
// 5 -> 10 нет

Console.WriteLine("Введите первое число:"); // подсказка для пользователя
int number = int.Parse(Console.ReadLine()); // получаем число
Console.WriteLine("Введите второе число число:");
int sqr = int.Parse(Console.ReadLine());
if (number * number == sqr)
    Console.WriteLine("Квадрат нашего сисла равен:" + number * number); // склейка сообщения + результат
else 
    Console.WriteLine("NO");

