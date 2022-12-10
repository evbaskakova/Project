// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m, n];

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)  
{
    for (int n = 0; n < array.GetLength(1); n++)  
    {
        array[m, n] = new Random().Next(-100,100);
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

void MeanСolumn(int[,] array)
{
for (int m = 0; m < array.GetLength(0); m++)
{
    int sum = 0;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        sum += array[m,n];
    }
   Console.Write($"{sum/array.GetLength(0)} ");
}
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
MeanСolumn(array);