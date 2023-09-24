// Задача №10
// 1.Напишите программу, которая выводит третью цифру заданного числа 
// 2.или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
bool LessDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Ошибка, число двухзначное!");
        return false;
    }
    return true;
}
int number;
Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());
if  (LessDigit(number))
{
    Console.WriteLine(ThirdDigit(number));
}