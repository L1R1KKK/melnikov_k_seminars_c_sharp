// // Задача 24: Напишите программу, которая
// // принимает на вход число (А) и выдаёт сумму чисел
// // от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

int SumNumbers(int num) //наш метод
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;  //sum = sum + i
        }
        
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Ошибка!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр от 1 до  A {number} = {sumNumbers}");
 

// int[] /*тип массива*/array/*название массива*/ = new int[122] /*размер массива*/;
// int[] /*тип массива*/array1/*название массива*/ = new int[8]{1, 2, 3123, 3, 44, 21, 12, 8}; /*размер массива*/;
// int[] /*тип массива*/array2/*название массива*/ = new int[]{1,2,3123,3,44,21, 12} /*размер массива*/;
// int[] /*тип массива*/array3/*название массива*/ = {1,2,3123,3,44,21, 12, 44} /*размер массива*/;

// var array4 = new int[8];

// string[] /*тип массива*/arrayStr/*название массива*/ = new string[122] /*размер массива*/;
// bool[] /*тип массива*/arrayBool/*название массива*/ = new bool[122] /*размер массива*/;
// Random[] /*тип массива*/rndArr/*название массива*/ = new Random[122] /*размер массива*/;

//  for (int i = 0; i < array.Length; i++)
//  {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
//  }
