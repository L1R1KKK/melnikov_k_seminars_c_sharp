// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] matrix = new int[,]; // rows =3,  columns = 4
    Random rnd = new();
void CreatMatrixRandomInt(int[,] arr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(x + 1);
        }
    }
    
}

int SumOnDigit(int[,] arr)
{
    int size = arr.GetLength(1);
    if (arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int[,] rndMatrix = CreatMatrixRandomInt(5, 4, 1, 10);
PrintMatrix(rndMatrix);

int sumOnDiagonal = SumOnDigit(rndMatrix);
Console.WriteLine($"Сумма элементов на главной диагонали равна - {sumOnDiagonal}");
