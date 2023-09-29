//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Ввод координатов
int Coordinate(string nameOne, string nameTwo)
{
    Console.Write($"Введите координату {nameOne} точки {nameTwo}: ");
    return Convert.ToInt32(Console.ReadLine());
}

//Основной метод
double DistanceBetweenPoints(double x1, double x2, double y1, double y2, double x3, double y3)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((y3 - x3), 2));
}

int x1 = Coordinate("X", "A");
int y1 = Coordinate("X2", "A");
int x3 = Coordinate("X3", "A");
int x2 = Coordinate("Y1", "B");
int y2 = Coordinate("Y2", "B");
int y3 = Coordinate("Y3", "B");

double segmentLength = Math.Round(DistanceBetweenPoints(x1, x2, y1, y2, y3, x3), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
