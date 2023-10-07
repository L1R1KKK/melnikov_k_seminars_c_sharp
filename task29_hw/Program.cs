// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message) //Ввод числа с экрана
{
    Console.Write(message); //Сам ввод
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput); // Перевод string в int
    return result; // Получение результата
}

int[] GenerateArray(int Length, int minValue, int maxValue) // Метод для получения случайных значений массива
{
    int[] array = new int[Length]; // Задаем массив
    Random random = new Random();  // Генерация цифр массива
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем случайными цифрами из даиапозона min -> max
    }
    return array;
}

void PrintArray(int[] array) // Наш массив
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Array length ");
int min = Prompt("Start array - ");
int max = Prompt("End array - ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);