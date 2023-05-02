// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// После загрузки задания, вы можете проверить себя самостоятельно с помощью эталонного решения

Main ();

void Main ()
{
    Console.WriteLine("Введите номер дня недели: ");
    int Number = int.Parse(Console.ReadLine());
    Days(Number);
}

void Days (int Number)
{
    if (Number > 5 && Number < 8)
    {
        Console.WriteLine("Выходной");
    }
    else if (Number > 0 && Number < 6)
    {
        Console.WriteLine("не выходной");
    }
    else 
    {
        Console.WriteLine("некорректное число");
    }
}