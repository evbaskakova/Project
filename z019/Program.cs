// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int [4, 6];

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

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите номер строки элемента: ");
int element1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбеца элемента: ");
int element2 = Convert.ToInt32(Console.ReadLine());

void PrintElement(int[,] array)
{
    if (element1 < 0 | element1 > array.GetLength(0) - 1 | element2 < 0 | element2 > array.GetLength(1) - 1)
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine("Значение элемента = {0}", array[element1, element2]);
            }
}

PrintElement(array);
