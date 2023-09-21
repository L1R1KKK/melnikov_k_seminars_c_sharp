// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int numberA, numberB, numberAB;

Console.WriteLine("Введите число №1: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3: ");
numberAB = Convert.ToInt32(Console.ReadLine());


if ((numberA > numberB) && (numberA > numberAB))
{
    Console.WriteLine($"{numberA} - Число №1 самое большое");
}
else if ((numberB > numberA) && (numberB > numberAB))
{
    Console.WriteLine($"{numberB} - Число №2 самое большое");
}
else if ((numberAB > numberA) && (numberAB > numberB))
{
    Console.WriteLine($"{numberAB} - Число №3 самое большое");
}