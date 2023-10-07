using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
          if (number > 9999 && number < 100000)
    {
    string name = number.ToString();
    string reverse = "";
    for (int i = name.Length - 1; i >= 0; i--)
    {
        reverse += name[i];
    }
    return true;
    }
    else return false;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64545;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        if(result == true)
        {
          System.Console.WriteLine($"{result}");
        }
        else System.Console.WriteLine($"Число не пятизначное\r\n{result}");
    }
}
//