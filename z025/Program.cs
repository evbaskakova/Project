// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int num = 4;
int[,] array = new int[num, num];

void FillArraySpiral(int[,] array, int x)
{
    int m = 0, n = 0;
    int element = 1;
    for (int e = 0; e < x * x; e++)
    {
        int k = 0;
        do { array[m, n++] = element++; } while (++k < x - 1);
        for (k = 0; k < x - 1; k++)
        {
             array[m++, n] = element++;
        }
        for (k = 0; k < x - 1; k++) 
        {
            array[m, n--] = element++;
        }
        for (k = 0; k < x - 1; k++) 
        {
            array[m--, n] = element++;
        }
        ++m; ++n;
        x = x < 2 ? 0 : x - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (array[m, n] < 10)
            {
                Console.Write("0" + array[m, n]);
                Console.Write(" ");
            }
            else Console.Write(array[m, n] + " ");
        }
        Console.WriteLine();
    }
}

FillArraySpiral(array, num);
PrintArray(array);