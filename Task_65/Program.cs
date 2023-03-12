// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberTwo = int.Parse(Console.ReadLine());
PrintNumber(numberOne, numberTwo);

void PrintNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        PrintNumber(num1 - 1, num2);
    }
    else if (num2 > num1)
    {
        PrintNumber(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else 
    {
        Console.Write($"{num2} ");
    }
}

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800
// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8