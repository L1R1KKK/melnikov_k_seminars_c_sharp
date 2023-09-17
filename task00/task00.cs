// Напишите программу, 

// 1. которая на вход
// 2. принимает число и выдаёт его квадрат (число
// 2. умноженное на само себя).


// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Ввод числа
Console.WriteLine("Введите целое число: ");
//Перевод нашего значения в число
int number =  Convert.ToInt32(Console.ReadLine());
//Функция квадрата числа
int square = number * number;
//Вывод результата
//Console.WriteLine(number + " -> " + square);
//Интерполяция строк
Console.WriteLine($"{number} -> {square}");
