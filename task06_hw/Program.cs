// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int numberA;

Console.WriteLine("Введите число ");
numberA = Convert.ToInt32(Console.ReadLine());
if(numberA % 2 == 0)
{
    Console.WriteLine($"{numberA}- Число четное");
}
else
{
    Console.WriteLine($"{numberA} - Число нечетное ");
}
//