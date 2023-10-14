// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

int Prompt(string message)
{
    Console.WriteLine(message);
    string value  = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] InPutArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} - й эллемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int CountPositeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int length = Prompt("Введите кол-во элементов >");
int[] array;
array = InPutArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во чисел > 0 - {CountPositeNumbers(array)}");