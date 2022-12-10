// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m==n)
{
    int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

void MinElements(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int m = 0; m < array.GetLength(1); m++)
    {
        min += array[0, m];
    }
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++) sum += array[m, n];
        if (sum < min)
        {
            min = sum;
            minSum = m;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка с наименьшей суммой элементов");
}
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    MinElements(array);
}
else Console.Write("С данными числами нельзя создать прямоугольный двумерный массив");