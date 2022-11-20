// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
int numA = 1;
int numB = 2;
int numC = 3;
int numD = 4;
int numE = 5;
int numF = 6;
int numJ = 7;

if (num == numA)
Console.Write("Сегодня не выходной");
else if (num == numB)
Console.Write("Сегодня не выходной");
else if (num == numC)
Console.Write("Сегодня не выходной");
else if (num == numD)
Console.Write("Сегодня не выходной");
else if (num == numE)
Console.Write("Сегодня не выходной");
else if (num == numF)
Console.Write("Сегодня выходной!");
else if (num == numJ)
Console.Write("Сегодня выходной!");
else if (num > 7)
Console.Write("Введите число от 1 до 7");
else if (num < 1)
Console.Write("Введите число от 1 до 7");
