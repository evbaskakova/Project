// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (a > 0)
{
    while (a > 0)
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}
else if (a < 0)
{
    a = a*(-1);
    while (a > 0)
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}
