// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

MassInit(Prompt());


int Prompt ()
{
    Console.WriteLine("Введите число, размер маччива: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void MassInit (int number)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next(0, 2);
        Console.Write(arr[i] + " ");
    }
    
}