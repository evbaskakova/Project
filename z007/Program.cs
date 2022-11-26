// Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();
void CheckingNumber(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
{
    Console.Write($"Число {num} палиндром");
}
else
{
    Console.Write($"Число {num} не палиндром");
}
}
if (num!.Length == 5)
{
    CheckingNumber(num);
}
else
{
    Console.Write("Введите пятизначное число: ");
}