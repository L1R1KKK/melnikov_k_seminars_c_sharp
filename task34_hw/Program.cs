// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];  //наш массив

void FillArray(int[] array, int min, int max) // создает наш массив из случайных чисел
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}

void WriteArray(int[] array) //пишет наш массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int QuantityPositive(int[] array) //проверяем положительное или нет
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

FillArray(array, 100, 1000); // указали диапозон 
WriteArray(array);
int quantity = QuantityPositive(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
