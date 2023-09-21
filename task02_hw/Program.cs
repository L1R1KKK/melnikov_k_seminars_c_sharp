// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA, numberB;

Console.WriteLine("Ввод первого числа: ");
numberA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод Второго числа числа: ");
numberB =  Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"{numberA} > {numberB} ");
}
else
{
    Console.WriteLine($"{numberA} < {numberB} ");
}
