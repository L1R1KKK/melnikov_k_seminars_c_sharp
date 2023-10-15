// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
using System;

Console.Clear();

int PowRecursive(int a, int b)
{
    if (b == 0) return 1;
    return a * PowRecursive(a, b - 1);
}
System.Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = PowRecursive(numberA, numberB);
System.Console.WriteLine($"{numberA}^{numberB} ->{result}");
