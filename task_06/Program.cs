﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
double nump = num % 2;
if (nump == 0)
{
    Console.WriteLine("Число " + num + " чётное");
}
else
{
    Console.WriteLine("Число " + num + " НЕ чётное");
}