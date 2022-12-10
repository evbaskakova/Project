// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        array[m, n] = new Random().Next(0,100);
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

FillArray(array);
PrintArray(array);
Console.WriteLine();


void NewFillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        for (int num = 0; num < array.GetLength(1) - 1; num++)
        {
            if (array[m, num] < array[m, num + 1])
            {
                int temp = array[m, num + 1];
                array[m, num + 1] = array[m, num];
                array[m, num] = temp;
            }
        }
    }
}
}

void NewPrintArray(int[,] array)
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

Console.WriteLine("Элементы массива по убыванию");
NewFillArray(array);
NewPrintArray(array);