// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел M: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;
  
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int m2 = Convert.ToInt32(Console.ReadLine());
    if (m2 > 0)
        count++;
}
Console.WriteLine($"Чисел больше 0 - {count}");



