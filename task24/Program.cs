// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num) //наш метод
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;  //sum = sum + i
        }
        
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Ошибка!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр от 1 до  A {number} = {sumNumbers}");
// int j = 2048;
// byte bb = (byte)j;
// Console.WriteLine(bb);