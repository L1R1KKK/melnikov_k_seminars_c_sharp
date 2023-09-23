//9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random(). Next (10, 99 + 1); // от 10 до 99
Console.WriteLine($"Случайнойе число [10 , 99] -> {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // остаток от деления

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшую цифру [10 , 99] -> {firstDigit}");
else Console.WriteLine($"Random number from [10 , 99] -> {secondDigit}");