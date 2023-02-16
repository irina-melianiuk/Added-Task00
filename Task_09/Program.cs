// 9. Напишите программу, которая выводит
// 1) случайное число из отрезка [10, 99] и 
// 2) показывает наибольшю цифру числа.
// 78 -> 8 // 78 / 10=7.8, а нам надо целую часть.
// 12 -> 2
// 85 -> 8


int number = new Random().Next(10, 100);  // 99+1т.к последнее число диапозона не войдет
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;  // целочисленное деление
int secondDigit = number % 10;  // остаток от деления на 10
if (firstDigit > secondDigit)
 Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else 
  Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");