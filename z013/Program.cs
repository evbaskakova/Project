// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] number = new int[13];

void New_Array (int[] number)
{
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(100,1000);
    Console.Write(number[i] + " ");
}
}

int even = 0;

void Even_Arr (int[] number)
{
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        even++;
    }
}
if (even % 10 == 1)
{
    Console.WriteLine($"Количество чётных чисел в массиве = {even}");
}
if (even % 10 == 2 || even % 10 == 3 || even % 10 == 4)
{
    Console.WriteLine($"Количество чётных чисел в массиве = {even}");
}
else

    Console.WriteLine($"Количество чётных чисел в массиве = {even}");
}

New_Array(number);
Console.WriteLine();
Even_Arr(number);