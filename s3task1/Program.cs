// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

main();

void main ()
{
    int QuaterNumber = Prompt ("Введите номер четверти: ");
    PrintCoordinate (QuaterNumber);
}

int Prompt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintCoordinate (int Number)
{
    if (Number == 1)
    {
       Console.WriteLine("X > 0 и Y > 0"); 
    }
        if (Number == 2)
    {
       Console.WriteLine("X < 0 и Y > 0"); 
    }
        if (Number == 3)
    {
       Console.WriteLine("X < 0 и Y < 0"); 
    }
        if (Number == 4)
    {
       Console.WriteLine("X > 0 и Y < 0"); 
    }
}
