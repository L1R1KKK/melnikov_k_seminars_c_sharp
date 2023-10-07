// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

int num;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);

void TableSquare(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 5} -> {count * count, 5}");
        count += 1;
    }
}
//