// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшю цифру числа.
// 78 -> 8 // 78 / 10=7.8
// 12 -> 2
// 85 -> 8


int number = new Random().Next(10, 100);  // 99+1т.к последнее число диапозона не войдет
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
 Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else 
  Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");