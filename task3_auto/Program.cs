int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

TableCoube(num);

void TableCoube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 16} -> {count * count * count, 5}");
        count += 1;
    }
}
//