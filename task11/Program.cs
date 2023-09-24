// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int num = new Random().Next(100, 1000);
Console.WriteLine($"На вход получаем число -> {num}");
// int firstNum = num / 100;
// int lastNum = num % 10;
// int result = firstNum * 10 + lastNum;
// Console.WriteLine($"Двухзначное число -> {result}");

int DeleteSecondDigit(int number)
{
    int firstNum = number / 100;
    int lastNum = number % 10;
    return firstNum * 10 + lastNum;
}

int res = DeleteSecondDigit(num);

Console.WriteLine(res);