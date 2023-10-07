// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultipleTwoNumbers(int num, int num1, int num2)
{
   return num % num1 == 0 && num % num2 == 0;
}

Console.WriteLine("Please enter first number: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 7;
int secondNumber = 23;
// if (number % firstNumber == 0 && number % secondNumber == 0)
// {
//     Console.WriteLine($"{number} -> yes");
// }
// else 

//     Console.WriteLine($"{number} -> no");
bool result = MultipleTwoNumbers(number, firstNumber, secondNumber);
Console.WriteLine(result ? $"{number} -> yes" :$"{number} -> no" );
//`