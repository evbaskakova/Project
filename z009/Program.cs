﻿// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());
for (double i=1; i<=N; i++)
{
    Console.WriteLine($"{i*i*i}");  
}