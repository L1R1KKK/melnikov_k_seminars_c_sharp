//9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99 + 1); // от 10 до 99 .Next - функция
Console.WriteLine($"Случайнойе число [10 , 99] -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // остаток от деления

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшую цифру [10 , 99] -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшиую цифру числа -> [10 , 99] -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //? - задаем вопрос : - иначе

// // string = string = "a" == "b" ? "nice" : ":("; - тернарный
// Console.WriteLine($"Наибольшиую цифру числа -> [10 , 99] -> {secondDigit}");

int maxDigit = MaxDigit(number);
 Console.WriteLine($"Наибольшиую цифру числа -> [10 , 99] -> {maxDigit}");
int MaxDigit(int numberr)
{
    int firstDigit = numberr / 10; // 78 / 10 = 7
    int secondDigit = numberr % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

