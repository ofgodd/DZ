﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите проверяемое число ");
double num1 = Convert.ToDouble(Console.ReadLine());
double num3 = num1/2;
if (num3%10 > 2);
{
    Console.Write("Число четное ");
}
else
{
    Console.Write("Число не четное ");
}