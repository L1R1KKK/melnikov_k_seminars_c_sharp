﻿// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] CreateMatrixSumIndex(int rows, int columns)
{
    //                       0       1
    int[,] matrix = new int[rows, columns]; // rows =3,  columns = 4

    for (int i = 0; i < matrix.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // по строкам
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("]");
    }
}
int[,] array2d = CreateMatrixSumIndex(15, 15);
PrintMatrix(array2d);