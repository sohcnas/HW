// Написать программу, которая на вход принимает одно число N, а на выход выход выводит 
// последовательность от -N до N

Console.WriteLine("Введите чило N");
int N = int.Parse(Console.ReadLine());
int i = -N;
while (i <= N)
{
    Console.Write(i + " ");
    i++;
}