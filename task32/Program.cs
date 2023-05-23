// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] array = new int[] {-4, -8, 8, 2};
int temp;
for (int i = 0; i < array.Length/2; i++)
{
    if (array[i] < 0)
    {
        temp = array[i];
        array[i] = array [array.Length-i-1];
        array [array.Length-i-1] = temp; 
    } 
}
foreach (var item in array)
{
    Console.WriteLine($" {item} ");    
}