// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);  
 Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

 int resDigit = ResultDigit(number);
 Console.WriteLine($"Вторая цифра числа = {resDigit}");
 
int ResultDigit(int num)
{
  int firstDigit = num / 10;  
  
  return (firstDigit % 10);
}
