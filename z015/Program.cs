// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] number = new int[7];

void New_Array (int[] number)
{
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(0,1000);
    Console.Write(number[i] + " ");
}
}
New_Array(number);
Console.WriteLine();

int max = number[0];
int min = number[0];

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > max)
    {
        max = number[i];
    }
    if (number[i] < min)
    {
    min = number[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");