// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n)
{
void Sum(int m, int n)
{
    Console.Write($"Cумма натуральных элементов в промежутке от M до N = {SumMN(m - 1, n)}");
}

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}
Sum(m, n);
}
else if (m > n)
{
    Console.Write ("Число M больше N, невозможно найти сумму натуральных элементов в промежутке от M до N");
}
else if (m == n)
{
    Console.Write ("Число M равно N, невозможно найти сумму натуральных элементов в промежутке от M до N");
}