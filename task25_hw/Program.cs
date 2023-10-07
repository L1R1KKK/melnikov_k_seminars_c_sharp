// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool Valid(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("new > 0");
        return false;
    }
    return true;
}

int powerBase = Prompt("Основание ");
int exponent = Prompt("Показатель ");
if (Valid(exponent))
{
    Console.WriteLine($"Number {powerBase} in degree {exponent} = {Power(powerBase, exponent)} ");
}