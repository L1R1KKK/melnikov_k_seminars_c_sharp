﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет



Console.WriteLine("Please enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool isSquareTwoNumbers (int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
bool result = isSquareTwoNumbers(firstNumber, secondNumber);
Console.WriteLine(result ? $"{firstNumber}, {secondNumber} -> yes" :$"{firstNumber}, {secondNumber} -> no" );