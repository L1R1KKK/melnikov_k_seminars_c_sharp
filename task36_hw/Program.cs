// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); //просим кол-во эллементов массива для RandomNubers

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("Получившийся массив: "); //сделал специально что бы воводилась надпись перед массивом
    Random rnd = new Random();
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = rnd.Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1) // проверка четной позиции
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(numberElements, 1, 10); //диапозон
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");
