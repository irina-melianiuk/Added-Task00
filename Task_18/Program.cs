﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти-- ");
int number = Convert.ToInt32(Console.ReadLine());


int quarter = Quarter(xc, yc);   
string result = quarter > 0 
                ? $"Указанные четверть соответствуют координатам {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if  (num == 1) return (x > 0, y > 0);
    if  (num == 2) return (x > 0, y < 0);
    if  (num == 3) return (x < 0, y < 0);
    if  (num == 4) return (x < 0, y > 0);
    return 0;
}