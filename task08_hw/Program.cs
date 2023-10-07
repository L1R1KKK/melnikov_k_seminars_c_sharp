// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int numberA, numberB;
Console.Write("Введите число: ");
numberA = Convert.ToInt32(Console.ReadLine());
numberB = 1;

if(numberA > numberB++)
{
    while(numberB <= numberA)
    {
        Console.Write(numberB + " ");
        numberB = numberB + 2;
    }
}
//