﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0)
{
    System.Console.WriteLine($"Ошибка! Число m не должно быть отрицательным!");
    return;
}
else if (n < 0)
{
    System.Console.WriteLine($"Ошибка! Число n не должно быть отрицательным!!");
    return;
}
int Ack(int numberM, int numberN)
{
  if (numberM == 0) return numberN + 1;
  else if (numberN == 0) return Ack(numberM - 1, 1);
  else return Ack(numberM - 1, Ack(numberM, numberN - 1));
}

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");
