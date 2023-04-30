// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Main ();

void Main ()
{
    Console.WriteLine("Введите первое число: ");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int Number2 = int.Parse(Console.ReadLine());
    if (Number1 % Number2 == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine("не кратно, остаток " + Number1 % Number2);
    }

}