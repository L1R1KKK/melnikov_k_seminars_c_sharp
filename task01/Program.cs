﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

int numberB, numberA;

Console.WriteLine("Ввод первого числа: ");
numberA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод второго числа: ");
numberB =  Convert.ToInt32(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine("Первое число является квадратом второго ");
}
else
{
    Console.WriteLine("Первое число  не является квадратом второго ");
}