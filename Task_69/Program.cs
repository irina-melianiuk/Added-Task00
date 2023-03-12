﻿// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberTwo = int.Parse(Console.ReadLine());

if(numberTwo < 0) Console.Write("Ошибка ввода");
else Console.WriteLine($"{numberOne}, {numberTwo} -- {PowNumber(numberOne,numberTwo)}");

int PowNumber(int a, int n)
{
    if (n == 0) return 1;
    else return a * PowNumber(a, n-1);
}

// int PowerRecMath(int a, int n)
// {
//     //return n == 0 ? 1 : PowerRec(a, n - 1) * a;   // тернарный оператор
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.Write("Введите число A: ");
// int numberOne = int.Parse(Console.ReadLine());

// Console.Write("Введите число B: ");
// int numberTwo = int.Parse(Console.ReadLine());

// Console.Write($"Число {numberOne} в степени {numberTwo} = ");
// Console.WriteLine(PowerRecMath(numberOne, numberTwo));