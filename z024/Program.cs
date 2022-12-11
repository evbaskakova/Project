// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];

void FillArray3D(int[,,] array)
{
    int count = 10;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int x = 0; x < array.GetLength(2); x++)
            {
                array[x, m, n] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex3D(int[,,] array)
{
    for (int m = 0; m < array3D.GetLength(0); m++)
    {
        for (int n = 0; n < array3D.GetLength(1); n++)
        {
            Console.WriteLine();
            for (int x = 0; x < array3D.GetLength(2); x++)
            {
                Console.Write($"{array3D[m, n, x]}({m},{n},{x}) ");
            }
        }
    }
}

FillArray3D(array3D);
PrintIndex3D(array3D);
