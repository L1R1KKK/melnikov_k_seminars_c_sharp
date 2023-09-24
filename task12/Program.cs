// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Please enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int RemainderNumber (int num1, int num2)
{
    return num1 % num2;
} 

int remainderNumber = RemainderNumber(firstNumber, secondNumber);

if (remainderNumber == 0) 
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно ");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {remainderNumber}");
}