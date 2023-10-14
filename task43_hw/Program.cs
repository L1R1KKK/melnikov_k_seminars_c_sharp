// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coefficent = 0;
const int constant = 1;
const int xcord = 0;
const int ycord = 1;
const int line1 = 1;
const int line2 =2;

double[] lineData1 = InPutLineData(line1);
double[] lineData2 = InPutLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения y = {lineData1[coefficent]} * x + {lineData1[coefficent]} и {lineData2[coefficent]} * x + {lineData2[coefficent]}");
    Console.WriteLine($" имеет координаты ({coord[xcord]}, {coord[ycord]})");

}
double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result =Convert.ToDouble(value);
    return result;
}
double[] InPutLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficent] = Prompt($"Введите коофицент для {numberOfLine} прямой >");
    lineData[constant] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[xcord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficent] - lineData1[coefficent]);
    coord[ycord] = lineData1[constant] * coord[xcord] + lineData1[constant];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficent] == lineData2[coefficent])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совподают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельные");
            return false;
        }
    }
    return true;
}