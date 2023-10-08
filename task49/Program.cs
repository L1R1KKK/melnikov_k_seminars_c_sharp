// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
Console.Clear();

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                       0       1
    int[,] matrix = new int[rows, columns]; // rows =3,  columns = 4
    Random rnd = new();

    for (int i = 0; i < matrix.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrixOrigin(int[,] matrix)
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
void PrintMatrixReplays(int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if( i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}
int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrixOrigin(array2d);

Console.WriteLine();

PrintMatrixReplays(array2d);
PrintMatrixOrigin(array2d);