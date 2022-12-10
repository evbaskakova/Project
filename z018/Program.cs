// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)  
{
    for (int n = 0; n < array.GetLength(1); n++)  
    {
        array[m, n] = Convert.ToDouble(new Random().Next(-100,100))/5;
    }
}
}

void PrintArray(double[,] array)
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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();