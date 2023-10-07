// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max) //метод создания массива
{
    int[] arr = new int[size]; // размер массива
    Random rnd = new Random();

    for (int i = 0; i < size; i++) // проход по всем эллементам массива 
    {
        arr[i] = rnd.Next(min, max + 1); //заполнение массива случайными целыми числами
    }

    return arr; // возвращаем наш массив
}

void PrintArray(int[] arr) // метод для вывода массива в консоль
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] GetSumPositiveNegativeElem(int[] arr) //метод который возвращает нам одномерный массив с 2 результатами
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[] { sumPositive, sumNegative };
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }

    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9); //длинна массива и диапозон
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);

Console.WriteLine($"Сумма положительных элементов => {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов => {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);

Console.WriteLine($"Сумма положительных элементов => {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов => {sumNegativeElem}");
//