// Задача 10: Напишите программу, которая:
// 1.принимает на вход трёхзначное число
// 2.на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num >= 1000)
{
    Console.WriteLine("Ошибка");
    return;
}
Console.WriteLine($"Введеное число:{num}");
int secondDigit = num / 10 % 10;
Console.WriteLine($"Вторая цифра: {secondDigit}");
