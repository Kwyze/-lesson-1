﻿Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.WriteLine("Первое число "  + a +  " больше второго " + b);
}
else
{
Console.WriteLine("Второе число " + b + " больше первого " + a);
}