// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Clear();
double[] arrayRealNumbers = new double[10]; //создаем наш массив с кол-во элментов

Random rnd = new Random();
double min = 10.00;
double max = 100.00;
Console.Write($"Получившийся массив -> ");
for (int i = 0; i < arrayRealNumbers.Length; i++) // даем диапозон и выводим на экран
{
    arrayRealNumbers[i] = rnd.NextDouble() * (max - min) + min ;
    
    Console.Write($"{arrayRealNumbers[i]:F2}  ");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({maxNumber:F2}) и минимальным({minNumber:F2}) элементами: {decision:F2}");
