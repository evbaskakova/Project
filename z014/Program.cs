// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] number = new int[13];

void New_Array (int[] number)
{
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(-1000,1000);
    Console.Write(number[i] + " ");
}
}
New_Array(number);
Console.WriteLine();

int summ = 0;

for (int i = 0; i < number.Length; i++)
{
    if (i % 2 != 0)
    {
        summ += number[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {summ}");

