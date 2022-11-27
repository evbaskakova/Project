// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;
if (b > 0)
{
    for(int i = 1; i < b; i++)
{
   num = num * a;
}
    Console.Write(num);
}
else if (b < 0)
{
    b = b*(-1);
    for(int i = 1; i < b; i++)
{
   num = num * a;
}
Console.Write(num);
}

else Console.Write("1");    // если b = 0