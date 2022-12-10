// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] array2 = new int[m, n];
int[,] resultArray = new int[m, n];

void FillArray1(int[,] array)
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
void FillArray2(int[,] array2)
{
    for (int m = 0; m < array2.GetLength(0); m++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            array2[m, n] = new Random().Next(1, 10);
        }
    }
}

void FillArray3(int[,] resultArray)
{for (int m = 0; m < array.GetLength(0); m++)
{
    for (int n = 0; n < array2.GetLength(1); n++)
    {
        resultArray[m, n] = 0;
        for (int x = 0; x < array.GetLength(1); x++)
        {
            resultArray[m, n] += array[m, x] * array2[x, n];
        }
    }
}
}
FillArray1(array);
PrintArray(array);
Console.WriteLine();
FillArray2(array2);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
FillArray3(resultArray);
PrintArray(resultArray);