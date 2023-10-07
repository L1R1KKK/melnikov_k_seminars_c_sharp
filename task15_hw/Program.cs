// Задча №15
// 1.Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// 2.и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool DayWeek(int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня не существует");
    return false;
}
bool WeekEnd(int weekend)
{
    if (weekend > 5)
    {
        return true;
    }
    return false;
}
int weekend;
Console.WriteLine("Введите день недели: ");
weekend = Convert.ToInt32(Console.ReadLine());
if (DayWeek(weekend))
{
    if (WeekEnd(weekend))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}

//